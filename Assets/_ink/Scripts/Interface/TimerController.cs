using UnityEngine;
using TMPro;
using ScriptableObjectArchitecture;

public class TimerController : MonoBehaviour
{
    public FloatVariable timer;
    public BoolVariable isTimerRunning;
    public StringVariable text;

    void FixedUpdate()
    {
        if(isTimerRunning.Value && timer.Value > 0)
        {
            timer.Value -= Time.deltaTime;
            text.Value = timer.Value.ToString("0.00");
        }
    }
}
