using UnityEngine;
using ScriptableObjectArchitecture;

public class FloatPercentageController : MonoBehaviour
{
    public FloatVariable max, current;
    public FloatVariable percentage;

    private void FixedUpdate()
    {
        percentage.Value = current.Value / max.Value;
    }
}
