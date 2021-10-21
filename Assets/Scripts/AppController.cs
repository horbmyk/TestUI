using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class AppController : MonoBehaviour
    {
        public delegate void AppsControllerOnClick(Sprite logo, string name, string rating);
        private AppsControllerOnClick _appsControllerOnClick;
        [SerializeField] private Text _name;
        [SerializeField] private Text _sequenceNumber;
        [SerializeField] private Text _rating;
        private Sprite _logoImage;

        public Text Name
        {
            get => _name;
            set => _name = value;
        }

        public Text SequenceNumber
        {
            get => _sequenceNumber;
            set => _ = value;
        }

        public Sprite LogoImage
        {
            get => _logoImage;
            set => _ = value;
        }

        public Text Rating
        {
            get => _rating;
            set => _ = value;
        }

        public void Initialization(string name, string sequenceNumber, Sprite logoImage, string rating, AppsControllerOnClick appsControllerOnClick)
        {
            Name.text = "  " + name;
            SequenceNumber.text = "  " + sequenceNumber;
            _logoImage = logoImage;
            _rating.text = " Rating: " + rating;
            _appsControllerOnClick = appsControllerOnClick;
        }

        public void OnClick()
        {
            _appsControllerOnClick?.Invoke(LogoImage, Name.text, Rating.text);
        }
    }
}
