using UnityEngine;
using ScriptableObjectArchitecture;

public class LevelStartController : MonoBehaviour
{
    public GameEvent gameStartedEvent;

    private void Awake()
    {
        gameStartedEvent.Raise();
    }
}
