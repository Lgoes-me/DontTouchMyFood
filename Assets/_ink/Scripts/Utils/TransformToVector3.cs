using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Utils
{
    public class TransformToVector3 : MonoBehaviour
    {
        public Vector3Variable position;

        void Update()
        {
            position.Value = transform.position;
        }
    }
}