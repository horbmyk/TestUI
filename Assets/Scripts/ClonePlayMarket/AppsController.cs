using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class AppsController : MonoBehaviour
    {
        [SerializeField] private Sprite[] AppImagesSource;
        [SerializeField] private GameObject PrefabItemApp;
        [SerializeField] private Transform ContentApp;
        //Add Rate

        private void Start()
        {
            InitializationApps();
        }

        private void InitializationApps()
        {
            var _sequenceNumber = 1;

            foreach (var item in AppImagesSource)
            {
                GameObject itemSources = Instantiate(PrefabItemApp, ContentApp.transform);
                itemSources.GetComponent<Image>().sprite = item;
                itemSources.GetComponent<AppController>().Initialization(item.name, _sequenceNumber.ToString(), item);
                _sequenceNumber++;
            }
        }
    }
}
