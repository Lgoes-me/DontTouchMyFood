using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class DraggingState : EntityState
    {
        public Vector3Variable inputPosition;
        private Vector3 offset;

        public UnityEvent coroutineEvent;

        public float waitTime;
        public float speed;

        private bool _touched;

        public override void OnStateInputReceived(bool touch)
        {
            base.OnStateInputReceived(touch);

            _touched = touch;
            offset = inputPosition.Value - transform.localPosition;
            StartCoroutine(InputCoroutine());
        }


        public override void OnStateUpdate()
        {
            if (_touched)
            {
                Vector3 position = new Vector3(inputPosition.Value.x, inputPosition.Value.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, position, speed);
            }
        }

        private IEnumerator InputCoroutine()
        {
            yield return new WaitForSeconds(waitTime);
            coroutineEvent.Invoke();
        }
    }
}