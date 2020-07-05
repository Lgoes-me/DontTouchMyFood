using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class ComingState : EntityState
    {
        public FloatVariable minSpeed;
        public FloatVariable maxSpeed;
        
        public UnityEvent colisionEvent;

        private float _speed;
        private string _collisionTag = "plate";

        private Coroutine _waitToAcelerate = null;

        public override void OnStateEnter()
        {
            base.OnStateEnter();
            _speed = minSpeed.Value;
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
                _controller.SetState(this.GetComponent<WaitingState>());
            }
        }

        public override void OnStateCollision(Collision2D collision)
        {
            base.OnStateCollision(collision);

            if (collision.transform.CompareTag(_collisionTag))
            {
                _rigidbody2D.velocity = Vector2.zero;
                colisionEvent.Invoke();
            }
        }

        public override void OnStateExit()
        {
            base.OnStateExit();

            if(_waitToAcelerate != null)
            {
                StopCoroutine(_waitToAcelerate);
            }
        }

        private void OnBecameVisible()
        {
            _waitToAcelerate = StartCoroutine(WaitToAcelerate());
        }

        private IEnumerator WaitToAcelerate()
        {
            yield return new WaitForSeconds(0.5f);
            _speed = Random.Range(minSpeed.Value,maxSpeed.Value);
        }
    }
}
