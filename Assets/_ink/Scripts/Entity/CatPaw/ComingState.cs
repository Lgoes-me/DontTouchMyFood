using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class ComingState : EntityState
    {
        public float speed;
        public IntGameEvent scoreEvent;
        public int positiveScore, negativeScore;

        public override void OnStateUpdate()
        {
            _rigidbody2D.velocity = speed * transform.up;
        }

        public override void OnStateInputReceived(bool input)
        {
            base.OnStateInputReceived(input);

            if (input)
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
                _rigidbody2D.velocity = Vector2.zero;
                scoreEvent.Raise(negativeScore);
                _controller.SetState(this.GetComponent<WaitingState>());
            }
        }
    }
}
