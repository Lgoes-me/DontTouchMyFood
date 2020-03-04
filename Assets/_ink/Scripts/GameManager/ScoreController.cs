using UnityEngine;
using ScriptableObjectArchitecture;

public class ScoreController : MonoBehaviour
{
    public IntVariable gameScore, feedingScore, feedingScoreGoal;

    public void AddScore(int value)
    {
        gameScore.Value = value;
    }
}
