using UnityEngine;
using UnityEngine.EventSystems;

public class TouchInputManager : MonoBehaviour , IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    private GameObject _touchedObject;
    private TouchInputReceiver _touchInputReceiver;

    public void OnBeginDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
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