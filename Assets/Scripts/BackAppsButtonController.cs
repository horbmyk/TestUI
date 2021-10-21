using UnityEngine;

namespace Tasks.UI
{
    public class BackAppsButtonController : MonoBehaviour
    {
        [SerializeField] private GameObject _backAppsButton;
        [SerializeField] private GameObject _contentApps;
        [SerializeField] private GameObject _settingButton;
        [SerializeField] private GameObject _choisedAppLayout;

        public void OnClick()
        {
            _backAppsButton.SetActive(false);
            _choisedAppLayout.SetActive(false);
            _contentApps.SetActive(true);
            _settingButton.SetActive(true);
        }
    }
}
