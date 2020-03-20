using System.Collections;
using UnityEngine;

namespace Ink.DontTouchMyFood.Entity
{
    public class LeavingState : EntityState
    {
        public float speed;
        public float waitTime;

        public override void OnStateEnter()
        {
            base.OnStateEnter();
            StartCoroutine(RemoveFromGame());
        }

        public override void OnStateUpdate()
        {
            _rigidbody2D.velocity = - speed * transform.up;
        }

        private IEnumerator RemoveFromGame()
        {
            yield return new WaitForSeconds(waitTime);
            Debug.Log("teste");
            gameObject.SetActive(false);
        }
    }
}