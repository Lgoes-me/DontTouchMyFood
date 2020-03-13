using UnityEngine; 
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.Timer
{
    public class TimerController : MonoBehaviour
    {
        public FloatVariable timer;
        public BoolVariable isTimerRunning;

        void FixedUpdate()
        {
            if (isTimerRunning.Value && timer.Value > 0)
            {
                timer.Value -= Time.deltaTime;
            }
        }

        public void SetTimerValue(float timerValue)
        {
            timer.Value = timerValue;
        }
    }
}