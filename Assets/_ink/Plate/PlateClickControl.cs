using ScriptableObjectArchitecture;
using UnityEngine;

public class PlateClickControl : MonoBehaviour
{
    public FloatVariable eatenPercentage;

    private void OnMouseOver()
    {
        eatenPercentage.Value += 0.1f;
    }
}
