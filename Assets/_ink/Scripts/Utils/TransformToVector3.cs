using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Utils
{
    public class TransformToVector3 : MonoBehaviour
    {
        public Vector3Variable position;

        private void Start()
        {
            Vector3 value = transform.position;

            if(position.Value != value) position.Value = value;
        }

        private void FixedUpdate()
        {
            /*
            Vector3 value = transform.position;

            if (position.Value != value) position.Value = value;
            */
        }
    }
}