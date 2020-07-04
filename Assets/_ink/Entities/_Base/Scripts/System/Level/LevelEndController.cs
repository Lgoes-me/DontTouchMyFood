using UnityEngine;
using ScriptableObjectArchitecture;

public class LevelEndController : MonoBehaviour
{
    public GameEvent levelStart;
    public GameObject lostGameCanvas;

    public void EndGame(bool didWin)
    {
        if (didWin)
        {
            levelStart.Raise();
        }
        else
        {
            lostGameCanvas.SetActive(true);
        }
    }
}
