using UnityEngine;

public class TouchInputReceiver : MonoBehaviour
{
    public bool isTouched = false;

    public void Touch(bool touch)
    {
        isTouched = touch;
    }
}
