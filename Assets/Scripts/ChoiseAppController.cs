using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class ChoiseAppController : MonoBehaviour
    {
        [SerializeField] private GameObject _layout;
        [SerializeField] private Image _logo;
        [SerializeField] private Text _name;
        [SerializeField] private Text _description;
        [SerializeField] private Text _rating;


        private void Awake()
        {
            _layout.SetActive(false);
        }

        public void SelectedApp(Sprite logo, string name, string rating)
        {
            _layout.SetActive(true);
            _logo.sprite = logo;
            _name.text = name;
            _description.text = "Description About" + name;
            _rating.text = rating;
        }

        public void OnClickInstall()
        {
            Debug.Log("Installing " + _name.text + " ...");
        }
    }
}
