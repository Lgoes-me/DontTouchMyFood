using UnityEngine;
using ScriptableObjectArchitecture;

public class InputReceiver : MonoBehaviour, IReceiver
{
    public BoolVariable isBeingTouched;

    public void Touch(bool isTouching)
    {
        isBeingTouched.Value = isTouching;
    }
}
