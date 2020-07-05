using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Ink.DontTouchMyFood.Entity
{
    public class WaitingState : EntityState
    {
        public float waitTime;
        public UnityEvent coroutineEvent;

        private Coroutine _return = null;

        public override void OnStateEnter()
        {
            base.OnStateEnter();
            _return = StartCoroutine(ReturnAfterCollision());
        }

        public override void OnStateExit()
        {
            base.OnStateExit();

            if (_return != null)
            {
                StopCoroutine(_return);
            }
        }

        private IEnumerator ReturnAfterCollision()
        {
            yield return new WaitForSeconds(waitTime);
            coroutineEvent.Invoke();
        }
    }
}
