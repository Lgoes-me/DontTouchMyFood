using System.Collections;
using UnityEngine;

namespace Ink.DontTouchMyFood.Entity
{
    public class WaitingState : EntityState
    {
        public float waitTime;

        public override void OnStateEnter()
        {
            base.OnStateEnter();

            StartCoroutine(ReturnAfterCollision());
        }

        private IEnumerator ReturnAfterCollision()
        {
            yield return new WaitForSeconds(waitTime);

            _controller.SetState(GetComponent<LeavingState>().stateName);
        }
    }
}
