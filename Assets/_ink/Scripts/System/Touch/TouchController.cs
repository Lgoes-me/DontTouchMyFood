using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.Touch
{
    public class TouchController : MonoBehaviour
    {
        public Vector3Variable inputPosition;

        private float _zDepth = -10;
        private Camera _camera;
        private LayerMask _mask;

        private GameObject _touchedObject;
        private TouchReceiver _touchInputReceiver;
        private Vector3 _touchPosWorld;

        private void Awake()
        {
            _camera = Camera.main;
            _mask = LayerMask.GetMask("Paw", "Plate");
        }

        private void FixedUpdate()
        {
            if (Input.GetMouseButton(0))
            {
                RaycastHit2D hitInformation = Physics2D.Raycast(_touchPosWorld, _camera.transform.forward, 15f, _mask);

                if (hitInformation.collider != null)
                {
                    GameObject newTouchedObject = hitInformation.transform.gameObject;

                    if (newTouchedObject != _touchedObject)
                    {
                        _touchedObject = newTouchedObject;

                        if (_touchedObject.GetComponent<TouchReceiver>() != null)
                        {
                            _touchInputReceiver = _touchedObject.GetComponent<TouchReceiver>();
                        }
                    }

                    _touchInputReceiver.Touch(true);
                }
                else
                {
                    if (_touchInputReceiver != null)
                    {
                        _touchInputReceiver.Touch(false);
                        _touchInputReceiver = null;
                        _touchedObject = null;
                    }
                }
            }
            else
            {
                if (_touchInputReceiver != null)
                {
                    _touchInputReceiver.Touch(false);
                    _touchInputReceiver = null;
                    _touchedObject = null;
                }
            }
        }

        private void Update()
        {
            _touchPosWorld = _camera.ScreenToWorldPoint(Input.mousePosition);
            _touchPosWorld.z = _zDepth;
            inputPosition.Value = _touchPosWorld;
        }
    }
}