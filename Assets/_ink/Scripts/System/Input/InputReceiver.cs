using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.Input
{
    public class InputReceiver : MonoBehaviour
    {
        public BoolVariable isBeingTouched;

        public void Touch(bool isTouching)
        {
            isBeingTouched.Value = isTouching;
        }
    }
}