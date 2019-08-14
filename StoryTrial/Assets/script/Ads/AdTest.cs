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

    public static int adsCount = 5;

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
        if (Advertisement.IsReady("BreakTimeVideo")&&Advertisement.IsReady("SpoilerAd"))
        {
            IsAdReady = true;
        }
    }

    public void ShowRewardAD(OnAdRewardCallBack callBack)
    {
        if (IsAdReady)
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            if(SpoilManager.CanSkip == true)
            {
                Advertisement.Show("BreakTimeVideo", options);
            }
            else if(SpoilManager.CanSkip == false)
            {
                Advertisement.Show("SpoilerAd", options);
                SpoilManager.CanSkip = true;
            }

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
