using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.GameInput
{
    public class TouchReceiver : MonoBehaviour
    {
        public BoolVariable isBeingTouched;

        public void Touch(bool isTouching)
        {
            bool value = isBeingTouched.Value;

            if (value != isTouching) isBeingTouched.Value = isTouching;
        }
    }
}