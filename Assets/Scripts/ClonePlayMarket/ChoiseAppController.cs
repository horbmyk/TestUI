using UnityEngine;

namespace Tasks.UI
{
    public class ChoiseAppController : MonoBehaviour
    {
        [SerializeField] private GameObject _choiseAppLayout;
        private void Awake()
        {
            _choiseAppLayout.SetActive(false);
        }

    }
}
