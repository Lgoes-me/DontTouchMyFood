using System.Collections;
using UnityEngine;

public class DraggingState : EnemyState
{
    public float zDepth;
    public Camera mainCamera;

    public float waitTime;
    private bool _isTouching;

    public override void OnStateEnter()
    {
        base.OnStateEnter();
        //StartCoroutine(ReturnAfterTouch());
    }

    public override void OnStateTouch(bool touch)
    {
        base.OnStateTouch(touch);

        _isTouching = touch;
    }

    public override void OnStateUpdate()
    {
        if (_isTouching)
        {
            destination = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDepth);
            destination = mainCamera.ScreenToWorldPoint(destination);
        }
    }

    /*
    private IEnumerator ReturnAfterTouch()
    {
        yield return new WaitForSeconds(waitTime);

        if (_isStateActive) enemy.SetState("Leaving");
    }
    */
}
