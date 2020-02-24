using UnityEngine;
using ScriptableObjectArchitecture;

public class ButtonInputController : MonoBehaviour
{
    public BoolVariable touch;

    public IntVariable score;
    public int scoreVariation;

    private void FixedUpdate()
    {
        if(touch.Value) score.Value += scoreVariation;
    }
}
