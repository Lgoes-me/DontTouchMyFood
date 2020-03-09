using UnityEngine;
using ScriptableObjectArchitecture;

public class ScriptableInputReceiver : MonoBehaviour
{
    public BoolVariable isBeingTouched;

    public void Touch(bool isTouching)
    {
        isBeingTouched.Value = isTouching;
    }
}
