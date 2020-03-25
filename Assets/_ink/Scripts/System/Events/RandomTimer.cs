using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class RandomTimer : MonoBehaviour
{
    public float minTime, maxTime;

    public bool runOnEnable = false;
    public bool loop = true;

    public UnityEvent timerEvent;

    public void InitTimer()
    {
        if (runOnEnable)
        {
            ExecuteEvent();
        }

        StartCoroutine(RunEvent());
    }

    public void StopTimer()
    {
        StopCoroutine(RunEvent());
    }

    private IEnumerator RunEvent()
    {
        float time = Random.Range(minTime, maxTime);

        yield return new WaitForSeconds(time);

        ExecuteEvent();

        if (loop) StartCoroutine(RunEvent());
    }

    private void ExecuteEvent()
    {
        timerEvent.Invoke();
    }
}