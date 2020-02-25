using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
    private GameObject _touchedObject;

    private IReceiver _touchInputReceiver;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        Vector3 touchPosWorld = _camera.ScreenToWorldPoint(Input.mousePosition);

        Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);

        RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, _camera.transform.forward);

        if (hitInformation.collider != null)
        {
            GameObject newTouchedObject = hitInformation.transform.gameObject;

            if (newTouchedObject != _touchedObject)
            {
                _touchedObject = newTouchedObject;

                if (_touchedObject.GetComponent<IReceiver>() != null)
                {
                    _touchInputReceiver = _touchedObject.GetComponent<IReceiver>();
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