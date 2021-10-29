using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class AppsController : MonoBehaviour
    {
        [SerializeField] private ChoiseAppController _choiseAppController;
        [SerializeField] private Sprite[] _imagesSource;
        [SerializeField] private GameObject _prefabItem;
        [SerializeField] private GameObject _settingButton;
        [SerializeField] private GameObject _backAppsButton;
        [SerializeField] private GameObject _appsPage;

        private void Start()
        {
            InitializationApps();
            _backAppsButton.SetActive(false);
        }

        private void InitializationApps()
        {
            foreach (var item in _imagesSource)
            {
                GameObject itemSources = Instantiate(_prefabItem, transform);
                itemSources.GetComponent<Image>().sprite = item;
                var rating = Random.Range(1, 5);
                itemSources.GetComponent<AppController>().Initialization(item.name, item, rating.ToString(), SelectedApp);
            }
        }

        public void SelectedApp(Sprite logo, string name, string rating)
        {
            _backAppsButton.SetActive(true);
            _settingButton.SetActive(false);
            _appsPage.SetActive(false);
            _choiseAppController.SelectedApp(logo, name, rating);
        }
    }
}
