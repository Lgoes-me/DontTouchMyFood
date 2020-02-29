using UnityEngine;
using TMPro;
using ScriptableObjectArchitecture;

public class TimerController : MonoBehaviour
{
    public FloatVariable timer;
    public BoolVariable isTimerRunning;

    void FixedUpdate()
    {
        if(isTimerRunning.Value && timer.Value > 0)
        {
            timer.Value -= Time.deltaTime;
        }
    }
}
