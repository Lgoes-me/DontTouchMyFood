using System.Collections;
using UnityEngine;
using ScriptableObjectArchitecture;
using Ink.DontTouchMyFood.Entity;

public class DraggingState : EntityState
{
    public Vector3Variable inputPosition;

    public float waitTime;
    public float speed;

    private bool _touched;

    public override void OnStateInputReceived(bool touch)
    {
        base.OnStateInputReceived(touch);
        
        _touched = touch;

        StartCoroutine(ReturnAfterTouch());
    }

    public override void OnStateUpdate()
    {
        if (_touched)
        {
            _rigidbody2D.position = Vector3.Lerp(transform.position, inputPosition.Value, speed);
        }
    }
    
    private IEnumerator ReturnAfterTouch()
    {
        yield return new WaitForSeconds(waitTime);

        _controller.SetState(GetComponent<LeavingState>());
    }
}
