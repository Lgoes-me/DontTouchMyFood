using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System
{
    public class GameEndController : MonoBehaviour
    {
        public void GameEnd(bool didWin)
        {
            if (didWin)
            {
                Debug.Log("ganhou");
            }
            else
            {
                Debug.Log("perdeu");
            }
        }
    }
}