using UnityEngine;
using UnityEngine.UI;


namespace Tasks.UI
{
    public class ItemScreenController : MonoBehaviour
    {
        [SerializeField] private Image _image;

        public void Initialization(Sprite image)
        {
            _image.sprite = image;
        }
    }
}
