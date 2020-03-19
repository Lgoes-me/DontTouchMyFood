using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System
{
    public class GameStartController : MonoBehaviour
    {
        public FloatVariable totalScore;
        public FloatVariable totalTimer;

        public float totalScoreValue;
        public float totalTimerValue;

        public GameEvent gameStartedEvent;

        private void Awake()
        {
            InitGame();
        }

        void InitGame()
        {
            totalScore.Value = totalScoreValue;
            totalTimer.Value = totalTimerValue;

            gameStartedEvent.Raise();
        }
    }
}
