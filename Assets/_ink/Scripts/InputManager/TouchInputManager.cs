using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInputManager : MonoBehaviour
{

    Vector3 touchPosWorld;
    
    private TouchPhase _touchPhase = TouchPhase.Ended;

    private Camera _camera;

    private GameObject _touchedObject;
    private TouchInputReceiver _touchInputReceiver;

    private void Awake()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == _touchPhase)
        {
            touchPosWorld = _camera.ScreenToWorldPoint(Input.GetTouch(0).position);

            Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);
            
            RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, _camera.transform.forward);

            if (hitInformation.collider != null)
            {
                GameObject newTouchedObject = hitInformation.transform.gameObject;
                   
                if(_touchedObject != null && _touchedObject != newTouchedObject)
                {
                    _touchedObject = newTouchedObject;
                    if(_touchedObject.GetComponent<TouchInputReceiver>())
                    {
                        _touchInputReceiver = _touchedObject.GetComponent<TouchInputReceiver>();
                    }
                }

                if(_touchInputReceiver != null)
                {
                    _touchInputReceiver.Touch(true);
                }
            }else
            {
                if (_touchInputReceiver != null)
                {
                    _touchInputReceiver.Touch(false);
                }
            }
        }
        else
        {
            if (_touchInputReceiver != null)
            {
                _touchInputReceiver.Touch(false);
            }
        }
    }
}