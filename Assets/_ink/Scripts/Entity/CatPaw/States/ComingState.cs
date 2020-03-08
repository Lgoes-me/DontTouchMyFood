using UnityEngine;
using ScriptableObjectArchitecture;
using Ink.DontTouchMyFood.Entity;

public class ComingState : EntityState
{
    public Vector3Variable platePosition;
    public float speed;
    public IntGameEvent scoreEvent;
    public int positiveScore, negativeScore;

    public override void OnStateUpdate()
    {
        _rigidbody2D.velocity = - speed * (transform.position - platePosition.Value).normalized ;
    }
    
    public override void OnStateInputReceived(bool touch)
    {
        base.OnStateInputReceived(touch);

        if (touch)
        {
            _rigidbody2D.velocity = Vector2.zero;
            scoreEvent.Raise(positiveScore);
            _controller.SetState(this.GetComponent<DraggingState>());
        }
    }

    public override void OnStateCollision(Collision2D collision)
    {
        base.OnStateCollision(collision);

        if (collision.transform.CompareTag("plate"))
        {
            scoreEvent.Raise(negativeScore);
            _controller.SetState(this.GetComponent<WaitingState>());
        }
    }
}
