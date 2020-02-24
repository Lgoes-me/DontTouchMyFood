using UnityEngine;

public class ComingState : PawState
{
    public Transform plateTransform;
    public float speed;

    public override void OnStateUpdate()
    {
        _rigidbody2D.velocity = - speed * (transform.position - plateTransform.position).normalized ;
    }

    public override void OnStateTouch(bool touch)
    {
        base.OnStateTouch(touch);

        if(touch) _controller.SetState( this.GetComponent<DraggingState>());
    }

    public override void OnStateCollision(Collision2D collision)
    {
        base.OnStateCollision(collision);

        if (collision.transform.CompareTag("plate")) _controller.SetState(this.GetComponent<WaitingState>());
    }
}
