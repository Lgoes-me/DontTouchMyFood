using UnityEngine;
using ScriptableObjectArchitecture;

public class ComingState : PawState
{
    public Vector3Variable platePosition;
    public float speed;

    public override void OnStateUpdate()
    {
        _rigidbody2D.velocity = - speed * (transform.position - platePosition.Value).normalized ;
    }

    public override void OnStateTouch(bool touch)
    {
        base.OnStateTouch(touch);

        if (touch)
        {
            _rigidbody2D.velocity = Vector2.zero;
            _controller.SetState(this.GetComponent<DraggingState>());
        }
    }

    public override void OnStateCollision(Collision2D collision)
    {
        base.OnStateCollision(collision);

        if (collision.transform.CompareTag("plate")) _controller.SetState(this.GetComponent<WaitingState>());
    }
}
