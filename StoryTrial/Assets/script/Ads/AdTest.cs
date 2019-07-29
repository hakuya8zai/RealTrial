using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdTest : MonoBehaviour {

    public static AdTest Inst;
    public delegate void OnAdRewardCallBack();
    OnAdRewardCallBack onAdRewardCallBack;

    private string GameID_IOS = "3236807";
    private string GameID_ANDROID = "3236806";

    public bool IsAdReady = false;

    public static int adsCount;

	// Use this for initialization
	void Start () {
        Inst = this;

#if UNITY_ANDROID
        Advertisement.Initialize(GameID_ANDROID,false);
#else
        Advertisement.Initialize(GameID_IOS, false);
#endif
    }
    public void CheckRewardIsReady()
    {
        if (IsAdReady) return;
        if (Advertisement.IsReady("BreakTimeVideo"))
        {
            IsAdReady = true;
        }
    }

    public void ShowRewardAD(OnAdRewardCallBack callBack)
    {
        if (IsAdReady)
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("BreakTimeVideo", options);
            IsAdReady = false;
            this.onAdRewardCallBack = callBack;
        }

    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("finished");
                if(this.onAdRewardCallBack != null)
                {
                    this.onAdRewardCallBack();
                    this.onAdRewardCallBack = null;
                }
                break;

            case ShowResult.Skipped:
                Debug.Log("Skipped");
                break;

            case ShowResult.Failed:
                Debug.Log("Failed");
                CheckRewardIsReady();
                break;

        }

    }


    public void AdrealTest()
    {

            AdTest.Inst.CheckRewardIsReady();
            if (AdTest.Inst.IsAdReady)
            {
                AdTest.Inst.ShowRewardAD(GiveResult);
                adsCount = 11;
                PlayerPrefs.SetInt("HP", adsCount);
            }
            else
            {
                Debug.Log("讀取失敗");
            }
        

    }

    void GiveResult()
    {
        Debug.Log("prizeeee");
    }

}
