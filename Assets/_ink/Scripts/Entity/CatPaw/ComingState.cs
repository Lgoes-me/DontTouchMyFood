using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class ComingState : EntityState
    {
        public float speed;
        public FloatGameEvent timerEvent;
        public float lostTime;
        private string _collisionTag = "plate";
        
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
                _controller.SetState(this.GetComponent<DraggingState>());
            }
        }

        public override void OnStateCollision(Collision2D collision)
        {
            base.OnStateCollision(collision);

            if (collision.transform.CompareTag(_collisionTag))
            {
                _rigidbody2D.velocity = Vector2.zero;
                timerEvent.Raise(lostTime);
                _controller.SetState(this.GetComponent<WaitingState>());
            }
        }

        private void OnBecameVisible()
        {
            speed = speed/2;
            StartCoroutine(WaitToAcelerate());
        }

        private IEnumerator WaitToAcelerate()
        {
            yield return new WaitForSeconds(1.5f);
            speed = speed * 3;
        }
    }
}
