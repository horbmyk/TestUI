using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class ChoiseAppController : MonoBehaviour
    {
        [SerializeField] private GameObject _layout;
        [SerializeField] private Text _description;
        [SerializeField] private Image _logo;

        private void Awake()
        {
            _layout.SetActive(false);
        }

        public void SelectedApp(Sprite logo, string description)
        {
            _layout.SetActive(true);
            _logo.sprite = logo;
            _description.text = description;
        }

        public void OnClickInstall()
        {
            Debug.Log("Installing " + _description.text + " ...");
        }
    }
}
