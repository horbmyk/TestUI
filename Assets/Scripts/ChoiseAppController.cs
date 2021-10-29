using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class ChoiseAppController : MonoBehaviour
    {
        [SerializeField] private GameObject _layout;
        [SerializeField] private GameObject _screensContent;
        [SerializeField] private GameObject _prefabItemScreen;
        [SerializeField] private Image _logo;
        [SerializeField] private Text _name;
        [SerializeField] private Text _description;
        [TextArea] [SerializeField] private string _longDescription;
        [SerializeField] private Text _rating;
        [SerializeField] private Text _ratingHead;

        private void Awake()
        {
            _layout.SetActive(false);
        }

        public void SelectedApp(Sprite logo, string name, string rating)
        {
            _layout.SetActive(true);
            _logo.sprite = logo;
            _name.text = name;
            _description.text = "Description About" + name + " :\n \n" + _longDescription;
            _description.GetComponent<ContentSizeFitter>().enabled = true;
            _rating.text = rating;
            _ratingHead.text = rating;

            foreach (Transform child in _screensContent.transform) Destroy(child.gameObject);

            for (int i = 0; i < 5; i++)
            {
                GameObject itemscreen = Instantiate(_prefabItemScreen, _screensContent.transform);
                itemscreen.GetComponent<ItemScreenController>().Initialization(logo);
            }

        }

        public void OnClickInstall()
        {
            Debug.Log("Installing " + _name.text + " ...");
        }
    }
}
