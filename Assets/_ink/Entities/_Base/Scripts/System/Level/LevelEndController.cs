using UnityEngine;
using UnityEngine.Events;
using ScriptableObjectArchitecture;

public class LevelEndController : MonoBehaviour
{
    public GameEvent levelStart;
    public UnityEvent lostGameEvent;

    public void EndGame(bool didWin)
    {
        if (didWin)
        {
            levelStart.Raise();
        }
        else
        {
            lostGameEvent.Invoke();
        }
    }
}
