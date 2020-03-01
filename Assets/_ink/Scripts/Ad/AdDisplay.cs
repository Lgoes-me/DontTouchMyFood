using UnityEngine;
using UnityEngine.Advertisements;

public class AdDisplay : MonoBehaviour
{
    public string myGameIdIOS = "3490464";
    public string myGameIdAndroid = "3490465";
    public string myVideoPlacement = "video";
    public bool adStarted;
    private bool testMode = true;
    
    void Start()
    {
        #if UNITY_IOS
         Advertisement.Initialize(myGameIdIOS, testMode);
        #else
        //#else if UNITY_ANDROID
         Advertisement.Initialize(myGameIdAndroid, testMode);
        #endif
    }

    void Update()
    {
        if (Advertisement.isInitialized && Advertisement.IsReady(myVideoPlacement) && !adStarted)
        {
            Advertisement.Show(myVideoPlacement);  adStarted = true;
        }  
    }
}
