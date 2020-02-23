using System.Collections;
using UnityEngine;

public class WaitingState : EnemyState
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

        enemy.SetState("Leaving");
    }
}
