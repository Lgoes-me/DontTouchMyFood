using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public float timer = 5f;

    public bool runOnEnable = false;
    public bool loop = true;

    public UnityEvent timerEvent;

    private WaitForSeconds _waitForSeconds;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(timer);
    }

    public void InitTimer()
    {
        if (runOnEnable)
        {
            ExecuteEvent();
        }

        StartCoroutine(RunEvent());
    }

    private IEnumerator RunEvent()
    {
        yield return _waitForSeconds;

        ExecuteEvent();

        if (loop) StartCoroutine(RunEvent());
    }

    private void ExecuteEvent()
    {
        timerEvent.Invoke();
    }
}