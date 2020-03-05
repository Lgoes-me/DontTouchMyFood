using UnityEngine;
using ScriptableObjectArchitecture;

public class GameManager : MonoBehaviour
{
    public IntVariable gameScore;
    public int gameScoreValue;

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
        gameScore.Value = gameScoreValue;
        foodScore.Value = foodScoreValue;
        initialTimer.Value = initialTimeValue;

        gameStartedEvent.Raise();
    }
}
