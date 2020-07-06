using UnityEngine;
using UnityEngine.EventSystems;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.GameInput
{
    public class TouchReceiver : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler, IPointerEnterHandler
    {
        public BoolVariable isBeingTouched;
        public Vector3Variable touchPosition;

        private Camera _camera;

        private void Awake()
        {
            _camera = Camera.main;
        }

        private void OnEnable()
        {
            isBeingTouched.Value = false;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            isBeingTouched.Value = true;
            Vector3 _touchPos = new Vector3(eventData.position.x, eventData.position.y, -10);
            _touchPos = _camera.ScreenToWorldPoint(_touchPos);
            touchPosition.Value = _touchPos;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            isBeingTouched.Value = true;
            Vector3 _touchPos = new Vector3(eventData.position.x, eventData.position.y, -10);
            _touchPos = _camera.ScreenToWorldPoint(_touchPos);
            touchPosition.Value = _touchPos;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            isBeingTouched.Value = false;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            isBeingTouched.Value = false;
        }

    }
}