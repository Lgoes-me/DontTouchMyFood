using UnityEngine;
using UnityEngine.Events;

public class Initializer : MonoBehaviour
{
    public UnityEvent initializerEvent;

    private void Awake()
    {
        initializerEvent.Invoke();
    }
}
