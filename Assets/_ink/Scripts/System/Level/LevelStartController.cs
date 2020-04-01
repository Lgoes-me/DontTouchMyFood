using UnityEngine;
using ScriptableObjectArchitecture;

public class LevelStartController : MonoBehaviour
{
    public GameEvent levelStartedEvent;

    private void Awake()
    {
        levelStartedEvent.Raise();
    }
}
