using UnityEngine;
using UnityEngine.EventSystems;

public class TouchInputReceiver : MonoBehaviour
{
    public bool isTouched = false;

    public void Touch(bool touchData)
    {
        isTouched = touchData;
    }
}
