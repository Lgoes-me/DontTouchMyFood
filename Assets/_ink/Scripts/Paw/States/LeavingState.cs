using UnityEngine;

public class LeavingState : PawState
{
    public Transform plateTransform;
    public float speed;

    public override void OnStateUpdate()
    {
        _rigidbody2D.velocity = speed * (transform.position - plateTransform.position).normalized;
    }
}
