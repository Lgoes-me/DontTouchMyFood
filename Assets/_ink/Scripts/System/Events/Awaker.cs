using UnityEngine;
using UnityEngine.Events;

public class Awaker : MonoBehaviour
{
    public UnityEvent initializerEvent;

    private void Awake()
    {
        initializerEvent.Invoke();
    }
}
