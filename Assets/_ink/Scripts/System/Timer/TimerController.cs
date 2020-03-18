using System.Collections;
using UnityEngine; 
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.Timer
{
    public class TimerController : MonoBehaviour
    {
        public FloatVariable currentTimer, timer;
        public BoolVariable isTimerRunning;

        private WaitForSeconds _timerWaiter = new WaitForSeconds(0.1F);

        public void Init()
        {
            StartCoroutine(Timer());
        }

        private IEnumerator Timer()
        {
            while (isTimerRunning.Value && currentTimer.Value < timer.Value)
            {
                currentTimer.Value += 0.1f;
                yield return _timerWaiter;
            }
            if(currentTimer.Value > timer.Value)
            {
                Debug.Log("Time is up");
            }
        }

        public void ReduceTimer(float lostTime)
        {
            currentTimer.Value += lostTime;
        }
    }
}