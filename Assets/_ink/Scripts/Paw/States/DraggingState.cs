using System.Collections;
using UnityEngine;

public class DraggingState : PawState
{
    public float zDepth;
    public Camera mainCamera;

    public float waitTime;
    public float speed;

    private bool _touched;

    public override void OnStateEnter()
    {
        base.OnStateEnter();
    }

    public override void OnStateTouch(bool touch)
    {
        base.OnStateTouch(touch);
        
        _touched = touch;

        StartCoroutine(ReturnAfterTouch());
    }

    public override void OnStateUpdate()
    {
        if (_touched)
        {
            Vector3 destination = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDepth);
            destination = mainCamera.ScreenToWorldPoint(destination);
            _rigidbody2D.position = Vector3.Lerp(transform.position, destination, speed);
        }
    }
    
    private IEnumerator ReturnAfterTouch()
    {
        yield return new WaitForSeconds(waitTime);

        _controller.SetState(GetComponent<LeavingState>());
    }
}
