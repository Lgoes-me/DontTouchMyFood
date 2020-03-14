using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.Input
{
    public class InputReceiver : MonoBehaviour
    {
        public BoolVariable isBeingTouched;

        public void Touch(bool isTouching)
        {
            bool value = isBeingTouched.Value;

            if (value != isTouching) isBeingTouched.Value = isTouching;
        }
    }
}