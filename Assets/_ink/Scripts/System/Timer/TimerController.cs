using UnityEngine; 
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.Timer
{
    public class TimerController : MonoBehaviour
    {
        public FloatVariable currentTimer, timer;
        public BoolVariable isTimerRunning;

        void FixedUpdate()
        {
            if (isTimerRunning.Value && currentTimer.Value < timer.Value)
            {
                currentTimer.Value += Time.deltaTime;
            }
        }
        
        public void ReduceTimer(float lostTime)
        {
            currentTimer.Value += lostTime;
        }
    }
}