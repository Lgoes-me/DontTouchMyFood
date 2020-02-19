using UnityEngine;

public class LeavingState : EnemyState
{
    public Transform plateTransform;

    public override void OnStateUpdate()
    {
        destination = plateTransform.position;
    }
}
