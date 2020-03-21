using UnityEngine;
using UnityEngine.Advertisements;


namespace Ink.DontTouchMyFood.System.Advertise
{
    public class AdvertiseController : MonoBehaviour
    {
        public string myGameIdIOS = "3490464";
        public string myGameIdAndroid = "3490465";
        public string myVideoPlacement = "video";
        public bool adStarted;
        private bool testMode = true;

        public void Init()
        {
#if UNITY_IOS
            Advertisement.Initialize(myGameIdIOS, testMode);
#else
            Advertisement.Initialize(myGameIdAndroid, testMode);
#endif
        }

        void Update()
        {
            if (Advertisement.isInitialized && Advertisement.IsReady(myVideoPlacement) && !adStarted)
            {
                Advertisement.Show(myVideoPlacement); adStarted = true;
            }
        }
    }
}