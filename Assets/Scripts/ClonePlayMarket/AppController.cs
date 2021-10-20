using UnityEngine;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class AppController : MonoBehaviour
    {
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

        public Sprite logoImage
        {
            get => _logoImage;
            set => _ = value;
        }

        public void Initialization(string description, string sequenceNumber, Sprite logoImage)
        {
            Description.text = "  " + description;
            SequenceNumber.text = "  " + sequenceNumber;
            _logoImage = logoImage;
        }
        public void OnClick()//
        {
            Debug.Log("You Chose " + Description.text);
        }
    }
}
