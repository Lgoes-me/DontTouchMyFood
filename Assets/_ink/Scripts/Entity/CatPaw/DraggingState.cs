using System.Collections;
using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class DraggingState : EntityState
    {
        public Vector3Variable inputPosition;
        private Vector3 offset;

        public float waitTime;
        public float speed;

        private bool _touched;

        public override void OnStateInputReceived(bool touch)
        {
            base.OnStateInputReceived(touch);

            _touched = touch;
            offset = inputPosition.Value - transform.localPosition;
            StartCoroutine(ReturnAfterTouch());
        }

        public override void OnStateUpdate()
        {
            Debug.Log(_touched);
            if (_touched)
            {
                _rigidbody2D.position = Vector3.Lerp(transform.position, new Vector3(inputPosition.Value.x - offset.x, inputPosition.Value.y - offset.y, inputPosition.Value.z), speed);
            }
        }

        private IEnumerator ReturnAfterTouch()
        {
            yield return new WaitForSeconds(waitTime);

            _controller.SetState(GetComponent<LeavingState>());
        }
    }
}
