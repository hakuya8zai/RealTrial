using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour {

    // Use this for initialization
    public GameObject FeverScreen;
    public static int levels = 0;
    /// <summary>
    /// level 為當前關卡數
    /// saveLevel為儲存最高關卡數
    /// </summary>

    void Awake() {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update() {
        if (RotateAround.GG == true)
        {
            Reload();
        }
        if (Input.GetKey(KeyCode.R))
        {
            levels = 1;
            PlayerPrefs.SetInt("saveLevel", levels);
        }
        print(levels);
        int s = PlayerPrefs.GetInt("saveLevel");
        print(s);
    }

    public void TimeBreak()
    {
        Time.timeScale = 0.0f;
    }

    public static void Reload()
    {

        AdTest.adsCount++;
        if (AdTest.adsCount >= 4)
        {
            AdTest.adsCount = 0;
            AdTest.Inst.AdrealTest();
        }
        SceneManager.LoadScene(levels);
    }
    public static void Nextload()
    {
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
