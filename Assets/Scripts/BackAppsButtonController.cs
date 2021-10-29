using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class BackAppsButtonController : MonoBehaviour
    {
        [SerializeField] private GameObject _backAppsButton;
        [SerializeField] private GameObject _contentApps;
        [SerializeField] private GameObject _settingButton;
        [SerializeField] private GameObject _choisedAppLayout;
        [SerializeField] private Text _description;

        public void OnClick()
        {
            _description.GetComponent<ContentSizeFitter>().enabled = false;
            _backAppsButton.SetActive(false);
            _choisedAppLayout.SetActive(false);
            _contentApps.SetActive(true);
            _settingButton.SetActive(true);
        }
    }
}
