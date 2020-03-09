using UnityEngine;
using UnityEngine.EventSystems;
using ScriptableObjectArchitecture;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private float zDepth;

    public Vector3Variable inputPosition;
    private Camera _camera;

    private GameObject _touchedObject;
    private ScriptableInputReceiver _touchInputReceiver;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        Vector3 touchPosWorld = _camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 touchPosWorld2D = new Vector3(touchPosWorld.x, touchPosWorld.y, zDepth);
        inputPosition.Value = touchPosWorld;

        RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, _camera.transform.forward);

        if (hitInformation.collider != null)
        {
            GameObject newTouchedObject = hitInformation.transform.gameObject;

            if (newTouchedObject != _touchedObject)
            {
                _touchedObject = newTouchedObject;

                if (_touchedObject.GetComponent<ScriptableInputReceiver>() != null)
                {
                    _touchInputReceiver = _touchedObject.GetComponent<ScriptableInputReceiver>();
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

        if (Input.GetMouseButtonDown(0))
        {
            if (_touchInputReceiver != null)
            {
                _touchInputReceiver.Touch(true);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (_touchInputReceiver != null)
            {
                _touchInputReceiver.Touch(false);
                _touchInputReceiver = null;
                _touchedObject = null;
            }
        }
    }
}