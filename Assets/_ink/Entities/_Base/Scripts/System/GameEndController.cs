using UnityEngine;
using ScriptableObjectArchitecture;
using Ink.DontTouchMyFood.System.Advertise;

namespace Ink.DontTouchMyFood.System
{
    public class GameEndController : MonoBehaviour
    {
        public ModuleController moduleController;

        public void GameEnd(bool didWin)
        {
            if (didWin)
            {
                moduleController.NextLevel();
            }
        }
    }
}