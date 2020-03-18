using UnityEngine;
using ScriptableObjectArchitecture;

public class GameManager : MonoBehaviour
{
    public IntVariable foodScore;
    public FloatVariable currentTimer;

    public GameEvent gameStartedEvent;

    private void Awake()
    {
        InitGame();
    }

    void InitGame()
    {
        foodScore.Value = 0;
        currentTimer.Value = 0;

        gameStartedEvent.Raise();
    }
}
