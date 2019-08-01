using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour {

    // Use this for initialization
    public static int levels = 1;
    /// <summary>
    /// level 為當前關卡數
    /// saveLevel為儲存最高關卡數
    /// </summary>
    public static bool ChangeCount = true;

    

    void Awake() {
        Time.timeScale = 1.0f;
    }

    private void Start()
    {

        AdTest.adsCount = PlayerPrefs.GetInt("HP");
    }

    // Update is called once per frame
    void Update() {
        if (RotateAround.GG == true)
        {
            Reload();
            RotateAround.GG = false;
        }
        if (Input.GetKey(KeyCode.R))
        {
            levels = 1;
            PlayerPrefs.SetInt("saveLevel", levels);
        }
        print(levels);
        int s = PlayerPrefs.GetInt("saveLevel");
        print(s);
        if (UIManager.UIOpen == true)
        { OnEnable(); }
        else
        { OnDisable(); }

        print(("ads") + AdTest.adsCount);
    }

    public void TimeBreak()
    {
        Time.timeScale = 0.0f;
    }

    public static void Reload()
    {
        AdTest.adsCount = PlayerPrefs.GetInt("HP");
        AdTest.adsCount = AdTest.adsCount-1;
        PlayerPrefs.SetInt("HP", AdTest.adsCount);
        print(AdTest.adsCount);
        if (AdTest.adsCount <= 0)
        {
            AdTest.adsCount = 11;
            PlayerPrefs.SetInt("HP", AdTest.adsCount);
            AdTest.Inst.AdrealTest();
        }
        SceneManager.LoadScene(levels);
    }
    public static void Nextload()
    {
        DeadBodyManager.ClearBody();
        levels++;
        int a = PlayerPrefs.GetInt("saveLevel");
        if (levels >= a)
        {
            PlayerPrefs.SetInt("saveLevel", levels);
        }
        SceneManager.LoadScene(levels);
    }

    public static void OnEnable()
    {///時間暫停
        Time.timeScale = 0.0f;
    }
    public static void OnDisable()
    {
        Time.timeScale = 1.0f;
    }


}
