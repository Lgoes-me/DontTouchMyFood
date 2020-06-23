using System.Collections;
using UnityEngine;

namespace Ink.DontTouchMyFood.Entity
{
    public class LeavingState : EntityState
    {
        public float speed;
        public float waitTime;

        private CapsuleCollider2D _capsuleCollider2D;

        public void Awake()
        {
            _capsuleCollider2D = GetComponent<CapsuleCollider2D>();
        }

        public override void OnStateEnter()
        {
            base.OnStateEnter();
            _capsuleCollider2D.isTrigger = true;
            StartCoroutine(RemoveFromGame());
        }

        public override void OnStateUpdate()
        {
            _rigidbody2D.velocity = - speed * transform.up;
        }

        private IEnumerator RemoveFromGame()
        {
            yield return new WaitForSeconds(waitTime);
            _capsuleCollider2D.isTrigger = false;
            gameObject.SetActive(false);
        }
    }
}