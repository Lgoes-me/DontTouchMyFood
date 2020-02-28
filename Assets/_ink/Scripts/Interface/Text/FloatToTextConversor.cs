using UnityEngine;
using ScriptableObjectArchitecture;

public class FloatToTextConversor : MonoBehaviour
{
    public FloatVariable floatValue;
    public StringVariable stringValue;

    public string formatting;

    private void FixedUpdate()
    {
        stringValue.Value = floatValue.Value.ToString(formatting);
    }
}
