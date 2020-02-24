using UnityEngine;
using ScriptableObjectArchitecture;

public class InputReceiver : MonoBehaviour
{
    public BoolVariable isBeingTouched;

    public void Touch(bool isTouching)
    {
        isBeingTouched.Value = isTouching;
    }
}
