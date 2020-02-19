using UnityEngine;

public class ButtonInputController : MonoBehaviour
{
    public float pontuation;
    public float pontuactionVariation;

    private void OnMouseOver()
    {
        pontuation += pontuactionVariation;
    }
}
