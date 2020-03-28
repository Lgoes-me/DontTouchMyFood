using System.Collections;
using UnityEngine;

public class RandomTimerActionController : MonoBehaviour
{
    public float minTime, maxTime;

    public bool runOnEnable = false;
    public bool loop = true;

    public SO_Controller controller;

    public void Awake()
    {
        controller.Init();
    }

    public void StartTimer()
    {
        if (runOnEnable)
        {
            ExecuteAction();
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

        ExecuteAction();

        if (loop) StartCoroutine(RunEvent());
    }

    private void ExecuteAction()
    {
        controller.DoControllerAction();
    }
}