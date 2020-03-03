using UnityEngine;
using ScriptableObjectArchitecture;

public class GameManager : MonoBehaviour
{
    public IntVariable foodScore;
    public int foodScoreValue;

    public FloatVariable initialTimer;
    public float initialTimeValue;

    public GameEvent gameStartedEvent;

    private void Awake()
    {
        InitGame();
    }

    void InitGame()
    {
        foodScore.Value = foodScoreValue;
        initialTimer.Value = initialTimeValue;

        gameStartedEvent.Raise();
    }
}
