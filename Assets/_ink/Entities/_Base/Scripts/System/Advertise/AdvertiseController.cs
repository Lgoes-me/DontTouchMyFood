using UnityEngine;

namespace Ink.DontTouchMyFood.System.Advertise
{
    public class AdvertiseController : MonoBehaviour//, IUnityAdsListener
    {
        /*
#if UNITY_ANDROID
        private static readonly string storeID = "3490465";
#elif UNITY_IOS
        private static readonly string storeID = "3490464";
#endif
        private static readonly string videoID = "video";
        private static readonly string rewardedID = "rewardedVideo";
        private static readonly string bannerID = "bannerAd";

        public UnityEvent onVideoEnd;
        public UnityEvent onRewardedEnd, onRewardedSkipped, onRewardedError;
        public UnityEvent onBannerEnd;

#if UNITY_EDITOR
        private static bool testMode = true;
#else
        private static bool testMode = false;
#endif
        private void Awake()
        {
            Advertisement.AddListener(this);
            Advertisement.Initialize(storeID, testMode);
        }

        public void InitVideo()
        {
            if (Advertisement.IsReady(videoID))
            {
                Advertisement.Show(videoID);
            }
        }

        public void InitRewarded()
        {
            if (Advertisement.IsReady(rewardedID))
            {
                Advertisement.Show(rewardedID);
            }
        }

        public void InitBanner()
        {
            StartCoroutine(ShowBannerWhenReady());
        }

        public static void HideBanner()
        {
            Advertisement.Banner.Hide();
        }

        private static IEnumerator ShowBannerWhenReady()
        {
            while (!Advertisement.IsReady(bannerID))
                yield return new WaitForSeconds(0.5f);

            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Show(bannerID);
        }

        public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
        {
            if (placementId == rewardedID)
            {
                switch (showResult)
                {
                    case ShowResult.Finished:
                        onRewardedEnd.Invoke();
                        break;
                    case ShowResult.Skipped:
                        onRewardedSkipped.Invoke();
                        break;
                    case ShowResult.Failed:
                        onRewardedError.Invoke();
                        break;
                }
            }
            else if(placementId == videoID)
            {
                onVideoEnd.Invoke();
            }
            else if (placementId == bannerID)
            {
                onBannerEnd.Invoke();
            }
        }

        public void OnUnityAdsReady(string placementId) { }

        public void OnUnityAdsDidError(string message) { }

        public void OnUnityAdsDidStart(string placementId) { }

        public void OnDestroy()
        {
            Advertisement.RemoveListener(this);
        }*/
    }
}