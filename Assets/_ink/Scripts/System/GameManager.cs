using UnityEngine;
using ScriptableObjectArchitecture;

public class GameManager : MonoBehaviour
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
