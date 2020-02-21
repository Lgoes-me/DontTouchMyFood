using UnityEngine;

public class ButtonInputController : MonoBehaviour
{


    public float pontuation;
    public float pontuactionVariation;

    public TouchInputReceiver touchInputReceiver;
    
    private void Update()
    {
        if(touchInputReceiver.isTouched) pontuation += pontuactionVariation;
    }
}
