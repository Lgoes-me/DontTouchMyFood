using UnityEngine;

public class LeavingState : EnemyState
{
    public Transform plateTransform;

    public override void OnStateUpdate()
    {
        destination = 10 * transform.position + (plateTransform.position - transform.position).normalized;
    }
}
