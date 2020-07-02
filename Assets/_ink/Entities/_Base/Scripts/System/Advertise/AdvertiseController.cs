using UnityEngine;
using UnityEngine.Advertisements;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.Advertise
{
    public class AdvertiseController : MonoBehaviour, IUnityAdsListener
    {
        public string myGameIdIOS = "3490464";
        public string myGameIdAndroid = "3490465";
        public string myVideoPlacement = "video";
        public bool adStarted;
        private bool testMode = true;

        public GameEvent startGame;

        private void Start()
        {
            Advertisement.AddListener(this);
#if UNITY_IOS
            Advertisement.Initialize(myGameIdIOS, testMode);
#else
            Advertisement.Initialize(myGameIdAndroid, testMode);
#endif
        }


        public void Init()
        {
            if (Advertisement.isInitialized && Advertisement.IsReady(myVideoPlacement) && !adStarted)
            {
                Advertisement.Show(myVideoPlacement);
                adStarted = true;
            }
        }

        public void OnUnityAdsReady(string placementId)
        {

        }

        public void OnUnityAdsDidError(string message)
        {

        }

        public void OnUnityAdsDidStart(string placementId)
        {

        }

        public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
        {
            // Define conditional logic for each ad completion status:
            if (showResult == ShowResult.Finished)
            {
                Debug.Log("Finished");
            }
            else if (showResult == ShowResult.Skipped)
            {
                Debug.Log("Skipped");
            }
            else if (showResult == ShowResult.Failed)
            {
                Debug.LogWarning("The ad did not finish due to an error.");
            }

            adStarted = false;
            startGame.Raise();
        }
        
        public void OnDestroy()
        {
            Advertisement.RemoveListener(this);
        }
    }
}