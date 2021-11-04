using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Tasks.UI
{
    public class InputController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        [SerializeField] private Image _panelInput;
        [SerializeField] private RectTransform _panelGroups;

        public void OnBeginDrag(PointerEventData eventData)
        {
            // _panelInput.raycastTarget = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
            {
                _panelInput.raycastTarget = false;

                if (eventData.delta.x > 0)
                {
                    Debug.Log("x  " + eventData.delta.x);
                }

                if (eventData.delta.x < 0)
                {
                    Debug.Log("x  " + eventData.delta.x);
                }
            }

            if (Mathf.Abs(eventData.delta.x) < Mathf.Abs(eventData.delta.y))
            {
                Debug.Log("y  " + eventData.delta.y);
                _panelInput.raycastTarget = true;
                _panelGroups.localPosition += new Vector3(0, eventData.delta.y, 0);
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            _panelInput.raycastTarget = true;
        }
    }
}
