using System.Collections;
using UnityEngine;

namespace Ink.DontTouchMyFood.Entity
{
    public class LeavingState : EntityState
    {
        public float speed;
        public float waitTime;

        private CapsuleCollider2D _capsuleCollider2D;
        private Coroutine _removeFromGame = null;

        public void Awake()
        {
            _capsuleCollider2D = GetComponent<CapsuleCollider2D>();
        }

        public override void OnStateEnter()
        {
            base.OnStateEnter();
            _capsuleCollider2D.isTrigger = true;
            _removeFromGame = StartCoroutine(RemoveFromGame());
        }

        public override void OnStateUpdate()
        {
            _rigidbody2D.velocity = - speed * transform.up;
        }

        public override void OnStateExit()
        {
            base.OnStateExit();

            if (_removeFromGame != null)
            {
                StopCoroutine(_removeFromGame);
            }
        }

        private IEnumerator RemoveFromGame()
        {
            yield return new WaitForSeconds(waitTime);
            _capsuleCollider2D.isTrigger = false;
            gameObject.SetActive(false);
        }
    }
}