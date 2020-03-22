using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System
{
    public class GameStartController : MonoBehaviour
    {
        public FloatVariable totalScore;
        public FloatVariable totalTimer;
        public FloatVariable currentScore;
        public FloatVariable currentTimer;

        public float totalScoreValue;
        public float totalTimerValue;

        public GameEvent gameStartedEvent;

        public void Awake()
        {
            totalScore.Value = totalScoreValue;
            totalTimer.Value = totalTimerValue;
            currentScore.Value = 0;
            currentTimer.Value = 0;
        }

        public void InitGame()
        {
            gameStartedEvent.Raise();
        }
    }
}
