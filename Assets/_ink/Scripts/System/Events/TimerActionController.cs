using System.Collections;
using UnityEngine;

public class TimerActionController : MonoBehaviour
{
    public float timer = 5f;

    public bool runOnEnable = false;
    public bool loop = true;

    public SO_Controller controller;

    private WaitForSeconds _waitForSeconds;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(timer);
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
        yield return _waitForSeconds;

        ExecuteAction();

        if (loop) StartCoroutine(RunEvent());
    }

    private void ExecuteAction()
    {
        controller.DoControllerAction();
    }
}