using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class ComingState : EntityState
    {
        public float minSpeed;
        public float maxSpeed;
        
        public FloatGameEvent timerEvent;
        public float lostTime;

        private float _speed;
        private string _collisionTag = "plate";

        public override void OnStateEnter()
        {
            base.OnStateEnter();
            _speed = minSpeed;
        }

        public override void OnStateUpdate()
        {
            _rigidbody2D.velocity = _speed * transform.up;
        }

        public override void OnStateInputReceived(bool input)
        {
            base.OnStateInputReceived(input);

            if (input)
            {
                _rigidbody2D.velocity = Vector2.zero;
                //_controller.SetState(this.GetComponent<DraggingState>().stateName);
            }
        }

        public override void OnStateCollision(Collision2D collision)
        {
            base.OnStateCollision(collision);

            if (collision.transform.CompareTag(_collisionTag))
            {
                _rigidbody2D.velocity = Vector2.zero;
                timerEvent.Raise(lostTime);
                //_controller.SetState(this.GetComponent<WaitingState>().stateName);
            }
        }

        private void OnBecameVisible()
        {
            StartCoroutine(WaitToAcelerate());
        }

        private IEnumerator WaitToAcelerate()
        {
            yield return new WaitForSeconds(1.5f);
            _speed = maxSpeed;
        }
    }
}
