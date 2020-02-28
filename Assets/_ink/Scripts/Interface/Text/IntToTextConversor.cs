using UnityEngine;
using ScriptableObjectArchitecture;

public class IntToTextConversor : MonoBehaviour
{
    public IntVariable intValue;
    public StringVariable stringValue;

    public string formatting;
    
    private void FixedUpdate()
    {
        stringValue.Value = intValue.Value.ToString(formatting);
    }
}
