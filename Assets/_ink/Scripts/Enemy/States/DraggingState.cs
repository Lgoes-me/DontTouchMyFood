using System.Collections;
using UnityEngine;

public class DraggingState : EnemyState
{
    public float zDepth;
    public Camera mainCamera;

    public float waitTime;
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
            destination = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDepth);
            destination = mainCamera.ScreenToWorldPoint(destination);
        }
    }
    
    private IEnumerator ReturnAfterTouch()
    {
        yield return new WaitForSeconds(waitTime);

        enemy.SetState("Leaving");
    }
}
