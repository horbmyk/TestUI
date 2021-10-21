using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class AppsController : MonoBehaviour
    {
        [SerializeField] private ChoiseAppController _choiseAppController;
        [SerializeField] private Sprite[] _imagesSource;
        [SerializeField] private GameObject _prefabItem;
        [SerializeField] private GameObject _contentApps;
        [SerializeField] private GameObject _settingButton;
        //Add Rate

        private void Start()
        {
            InitializationApps();
        }

        private void InitializationApps()
        {
            var _sequenceNumber = 1;

            foreach (var item in _imagesSource)
            {
                GameObject itemSources = Instantiate(_prefabItem, _contentApps.transform);
                itemSources.GetComponent<Image>().sprite = item;
                itemSources.GetComponent<AppController>().Initialization(item.name, _sequenceNumber.ToString(), item, SelectedApp);
                _sequenceNumber++;
            }
        }

        public void SelectedApp(Sprite logo, string description)
        {
            _settingButton.SetActive(false);
            _contentApps.SetActive(false);
            _choiseAppController.SelectedApp(logo, description);
        }
    }
}
