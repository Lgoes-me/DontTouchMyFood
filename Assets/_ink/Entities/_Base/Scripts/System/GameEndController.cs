using UnityEngine;
using Ink.DontTouchMyFood.System.Advertise;

namespace Ink.DontTouchMyFood.System
{
    public class GameEndController : MonoBehaviour
    {
        public AdvertiseController adController;
        public ModuleController moduleController;

        [Range(0, 100)]
        public int chance;

        public void GameEnd(bool didWin)
        {
            if (didWin)
            {
                moduleController.NextLevel();
            }
            else
            {
                moduleController.NextLevel();

                /*if (chance >= Random.Range(0, 100))
                {
                    adController.InitVideo();
                }*/
            }
        }
    }
}