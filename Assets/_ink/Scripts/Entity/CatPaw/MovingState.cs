using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Ink.DontTouchMyFood.Entity
{
    public class MovingState : EntityState
    {
        public float speed;
        public UnityEvent enterEvent, inputEvent, colisionEvent, waitEvent;

        public override void OnStateEnter()
        {
            base.OnStateEnter();
            enterEvent.Invoke();
        }

        public override void OnStateUpdate()
        {
            _rigidbody2D.velocity = speed * transform.up;
        }

        public override void OnStateInputReceived(bool input)
        {
            base.OnStateInputReceived(input);

            if (input)
            {
                inputEvent.Invoke();
            }
        }

        public override void OnStateCollision(Collision2D collision)
        {
            base.OnStateCollision(collision);
            colisionEvent.Invoke();
        }

        public void ChangeSpeed(float value)
        {
            speed = value;
        }

        public IEnumerator WaitCoroutine(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            waitEvent.Invoke();
        }
    }
}