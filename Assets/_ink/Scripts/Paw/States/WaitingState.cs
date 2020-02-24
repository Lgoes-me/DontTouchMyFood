using System.Collections;
using UnityEngine;

public class WaitingState : PawState
{
    public float waitTime;

    public override void OnStateEnter()
    {
        base.OnStateEnter();

        StartCoroutine(ReturnAfterCollision());
    }

    private IEnumerator ReturnAfterCollision()
    {
        yield return new WaitForSeconds(waitTime);

        _controller.SetState(GetComponent<LeavingState>());
    }
}
