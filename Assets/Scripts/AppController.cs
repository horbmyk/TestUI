using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class AppController : MonoBehaviour
    {
        public delegate void AppsControllerOnClick(Sprite logo, string name, string rating);
        private AppsControllerOnClick _appsControllerOnClick;
        [SerializeField] private Text _name;
        [SerializeField] private Text _size;
        private Sprite _logoImage;

        public Text Name
        {
            get => _name;
            set => _name = value;
        }

        public Sprite LogoImage
        {
            get => _logoImage;
            set => _ = value;
        }

        public Text Size
        {
            get => _size;
            set => _ = value;
        }

        public void Initialization(string name, Sprite logoImage, string size, AppsControllerOnClick appsControllerOnClick)
        {
            Name.text = "  " + name;
            _logoImage = logoImage;
            _size.text = size + " MB ";
            _appsControllerOnClick = appsControllerOnClick;
        }

        public void OnClick()
        {
            _appsControllerOnClick?.Invoke(LogoImage, Name.text, Size.text);
        }
    }

}
