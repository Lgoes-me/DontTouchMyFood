using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.Score
{
    public class ScoreController : MonoBehaviour
    {
        public IntVariable gameScore;

        public void AddScore(int value)
        {
            gameScore.Value += value;
        }
    }
}