using UnityEngine;
using ScriptableObjectArchitecture;
using Ink.DontTouchMyFood.System.Advertise;

namespace Ink.DontTouchMyFood.System
{
    public class GameEndController : MonoBehaviour
    {
        public AdvertiseController adController;

        public void GameEnd(bool didWin)
        {
            if (didWin)
            {
                Debug.Log("ganhou");
            }
            else
            {
                adController.Init();
            }
        }
    }
}