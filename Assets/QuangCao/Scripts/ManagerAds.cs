using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class ManagerAds : MonoBehaviour
{
    public static ManagerAds Ins;

    string REMOVE_ADS = "remove_ads";

    private UnityAction<bool> OnCompleteMethod;
    private UnityAction OnInterstitialClosed;

    private void Awake()
    {
        if (Ins == null)
        {
            Ins = this;
            DontDestroyOnLoad(this);
        }
        else if (Ins != this)
        {
            Destroy(gameObject);
        }
    }

    public void LogEvent(string name)
    {

    }

    public void RemoveAds()
    {
        PlayerPrefs.SetInt(REMOVE_ADS, 1);
        HideBanner();
    }

    public bool CanShowAds()
    {
        return PlayerPrefs.GetInt(REMOVE_ADS, 0) == 0;
    }

    //public void ShareApp()
    //{
    //    if (Application.platform == RuntimePlatform.Android)
    //    {
    //        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
    //        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");

    //        intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
    //        //AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
    //        //AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://" + imagePath);
    //        //intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);
    //        //intentObject.Call<AndroidJavaObject>("setType", "image/png");

    //        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"),
    //            URL_RATE + Application.identifier);
    //        intentObject.Call<AndroidJavaObject>("setType", "text/plain");
    //        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
    //        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

    //        AndroidJavaObject jChooser = intentClass.CallStatic<AndroidJavaObject>("createChooser", intentObject, "");
    //        currentActivity.Call("startActivity", jChooser);
    //    }

    //}

    public void ShowInterstitial(UnityAction callback = null)
    {
        OnInterstitialClosed = callback;
    }

    public bool IsRewardVideoAvailable()
    {
        return true;
    }    

    public void ShowRewardedVideo(UnityAction<bool> callback)
    {
        OnCompleteMethod = callback;
    }


    public void ShowRewardedVideoUnity()
    {

    }

    public void ShowFullUnity()
    {

    }

    public void ShowBanner()
    {

    }

    public void HideBanner()
    {

    }

    public void RequestInterstitial()
    {

    }
}
