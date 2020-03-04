using UnityEngine;
using ScriptableObjectArchitecture;

public class IntPercentageController : MonoBehaviour
{
    public IntVariable max, current;
    public FloatVariable percentage;
        
    private void FixedUpdate()
    {
        percentage.Value = (float) current.Value / max.Value;
    }
}
