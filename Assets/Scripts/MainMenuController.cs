using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField] private GameObject PrefabItemMainMenu;
        [SerializeField] private Transform ContentMainMenu;

        private void Awake()
        {
            for (int i = 0; i < 15; i++)
            {
                GameObject itemMainMenu = Instantiate(PrefabItemMainMenu, ContentMainMenu.transform);
                itemMainMenu.GetComponentInChildren<Text>().text = "Item Account " + (i + 1).ToString();
            }
        }
    }
}
