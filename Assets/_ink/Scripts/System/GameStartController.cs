using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System
{
    public class GameStartController : MonoBehaviour
    {
        public IntVariable finalScore;
        public FloatVariable totalTimer;

        public int finalScoreValue;
        public float totalTimerValue;

        public GameEvent gameStartedEvent;

        private void Awake()
        {
            InitGame();
        }

        void InitGame()
        {
            finalScore.Value = finalScoreValue;
            totalTimer.Value = totalTimerValue;

            gameStartedEvent.Raise();
        }
    }
}
