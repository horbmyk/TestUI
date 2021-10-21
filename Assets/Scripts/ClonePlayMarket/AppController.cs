using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class AppController : MonoBehaviour
    {
        public delegate void DelegateAppsController(Sprite logo, string description);//
        private DelegateAppsController _delegateAppsController;//
        [SerializeField] private ChoiseAppController _choiseAppController;
        [SerializeField] private Text _description;
        [SerializeField] private Text _sequenceNumber;
        private Sprite _logoImage;


        public Text Description
        {
            get => _description;
            set => _description = value;
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

        public void Initialization(string description, string sequenceNumber, Sprite logoImage, DelegateAppsController delegateAppsController)
        {
            Description.text = "  " + description;
            SequenceNumber.text = "  " + sequenceNumber;
            _logoImage = logoImage;
            _delegateAppsController = delegateAppsController;
        }

        public void OnClick()
        {
            _delegateAppsController?.Invoke(LogoImage, Description.text);
        }
    }
}
