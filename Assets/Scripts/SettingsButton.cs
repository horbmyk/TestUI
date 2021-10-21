using System.Collections;
using UnityEngine;

namespace Tasks.UI
{
    public class SettingsButton : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenu;
        [SerializeField] private Animator _settingsButton;
        private bool _isClick;

        private void Awake()
        {
            _mainMenu.SetActive(false);
        }

        public void OnClickSettingsButton()
        {
            _isClick = !_isClick;

            if (_isClick)
            {
                _mainMenu.SetActive(true);
                _settingsButton.SetTrigger("EnableSettingButton");
            }
            else
                StartCoroutine(DisableSettingButton());
        }

        IEnumerator DisableSettingButton()
        {

            _settingsButton.SetTrigger("DisableSettingButton");
            yield return new WaitForSeconds(1f);
            _mainMenu.SetActive(false);
        }
    }
}
