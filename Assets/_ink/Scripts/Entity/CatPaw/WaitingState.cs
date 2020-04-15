using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Ink.DontTouchMyFood.Entity
{
    public class WaitingState : EntityState
    {
        public float waitTime;
        public UnityEvent coroutineEvent;

        public override void OnStateEnter()
        {
            base.OnStateEnter();
            StartCoroutine(ReturnAfterCollision());
        }

        private IEnumerator ReturnAfterCollision()
        {
            yield return new WaitForSeconds(waitTime);
            coroutineEvent.Invoke();
        }
    }
}
