using UnityEngine;
using ScriptableObjectArchitecture;

public class LevelEndController : MonoBehaviour
{
    public BoolGameEvent levelEndEvent;

    public void EndGame(bool didWin)
    {
        levelEndEvent.Raise(didWin);
    }
}
