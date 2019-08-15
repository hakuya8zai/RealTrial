using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButtoms : MonoBehaviour {
    public GameObject removeObject;
    public GameObject playingCanvas;
    public GameObject HelpCanvas;
    public GameObject pauseCanvas;
    public int Key;
    public int Lock;



    private void Awake()
    {
        
        Key = PlayerPrefs.GetInt("saveLevel");
        if (Key <= 1)
        {
            Key = 1;
            PlayerPrefs.SetInt("saveLevel", Key);
            PlayerPrefs.SetInt("HP", 5);
            AdTest.adsCount = PlayerPrefs.GetInt("HP");
        }
    }

    private void Start()
    {
    }

    public void SelectOver()
    {
        DeadBodyManager.ClearBody();
        removeObject.SetActive(false);
        UIManager.UIOpen = false;
        playingCanvas.SetActive(true);
        HelpCanvas.SetActive(true);


        SpoilManager.spoilKey = false;


        AdTest.adsCount = PlayerPrefs.GetInt("HP");
        AdTest.adsCount = AdTest.adsCount - 1;
        PlayerPrefs.SetInt("HP", AdTest.adsCount);
        if (AdTest.adsCount <= 0)
        {
            AdTest.adsCount = 5;
            PlayerPrefs.SetInt("HP", AdTest.adsCount);
            AdTest.Inst.AdrealTest();
        }
    }
    public void ChapterOneButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 1;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(1);
            GameManagement.levels = 1;
            SelectOver();
        }
    }
    public void ChapterTwoButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 2;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(2);
            GameManagement.levels = 2;
            SelectOver();
        }
    }
    public void ChapterThreeButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 3;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(3);
            GameManagement.levels = 3;
            SelectOver();
        }
    }
    public void ChapterFourButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 4;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(4);
            GameManagement.levels = 4;
            SelectOver();
        }
    }
    public void ChapterFiveButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 5;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(5);
            GameManagement.levels = 5;
            SelectOver();
        }
    }
    public void ChapterSixButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 6;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(6);
            GameManagement.levels = 6;
            SelectOver();
        }
    }
    public void ChapterSevenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 7;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(7);
            GameManagement.levels = 7;
            SelectOver();
        }
    }
    public void ChapterEightButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 8;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(8);
            GameManagement.levels = 8;
            SelectOver();
        }
    }
    public void ChapterNineButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 9;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(9);
            GameManagement.levels = 9;
            SelectOver();
        }
    }
    public void ChapterTenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 10;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(10);
            GameManagement.levels = 10;
            SelectOver();
        }
    }
    public void ChapterElevenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 11;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(11);
            GameManagement.levels = 11;
            SelectOver();
        }
    }
    public void ChapterTwelveButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 12;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(12);
            GameManagement.levels = 12;
            SelectOver();
        }
    }
    public void ChapterThirteenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 13;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(13);
            GameManagement.levels = 13;
            SelectOver();
        }
    }
    public void ChapterFourteenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 14;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(14);
            GameManagement.levels = 14;
            SelectOver();
        }
    }
    public void ChapterFifteenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 15;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(15);
            GameManagement.levels = 15;
            SelectOver();
        }
    }
    public void ChapterSixteenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 16;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(16);
            GameManagement.levels = 16;
            SelectOver();
        }
    }
    public void ChapterSeventeenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 17;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(17);
            GameManagement.levels = 17;
            SelectOver();
        }
    }
    public void ChapterEighteenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 18;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(18);
            GameManagement.levels = 18;
            SelectOver();
        }
    }
    public void ChapterNineteenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 19;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(19);
            GameManagement.levels = 19;
            SelectOver();
        }
    }
    public void ChapterTwentyButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 20;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(20);
            GameManagement.levels = 20;
            SelectOver();
        }
    }
    public void ChapterTwentyoneButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 21;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(21);
            GameManagement.levels = 21;
            SelectOver();
        }
    }
    public void ChapterTwentytwoButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 22;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(22);
            GameManagement.levels = 22;
            SelectOver();
        }
    }
    public void ChapterTwentythreeButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 23;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(23);
            GameManagement.levels = 23;
            SelectOver();
        }
    }
    public void ChapterTwentyfourButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 24;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(24);
            GameManagement.levels = 24;
            SelectOver();
        }
    }
    public void ChapterTwentyfiveButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 25;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(25);
            GameManagement.levels = 25;
            SelectOver();
        }
    }
    public void ChapterTwentysixButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 26;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(26);
            GameManagement.levels = 26;
            SelectOver();
        }
    }
    public void ChapterTwentysevenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 27;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(27);
            GameManagement.levels = 27;
            SelectOver();
        }
    }
    public void ChapterTwentyeightButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 28;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(28);
            GameManagement.levels = 28;
            SelectOver();
        }
    }
    public void ChapterTwentynineButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 29;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(29);
            GameManagement.levels = 29;
            SelectOver();
        }
    }
    public void ChapterThirtyButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 30;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(30);
            GameManagement.levels = 30;
            SelectOver();
        }
    }
    public void ChapterThirtyoneButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 31;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(31);
            GameManagement.levels = 31;
            SelectOver();
        }
    }
    public void ChapterThirtytwoButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 32;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(32);
            GameManagement.levels = 32;
            SelectOver();
        }
    }
    public void ChapterThirtythreeButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 33;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(33);
            GameManagement.levels = 33;
            SelectOver();
        }
    }
    public void ChapterThirtyfourButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 34;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(34);
            GameManagement.levels = 34;
            SelectOver();
        }
    }
    public void ChapterThirtyfiveButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 35;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(35);
            GameManagement.levels = 35;
            SelectOver();
        }
    }
    public void ChapterThirtysixButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 36;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(36);
            GameManagement.levels = 36;
            SelectOver();
        }
    }
    public void ChapterThirtysevenButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 37;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(37);
            GameManagement.levels = 37;
            SelectOver();
        }
    }
    public void ChapterThirtyeightButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 38;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(38);
            GameManagement.levels = 38;
            SelectOver();
        }
    }
    public void ChapterThirtynineButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 39;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(39);
            GameManagement.levels = 39;
            SelectOver();
        }
    }
    public void ChapterFortyButtom()
    {
        Key = PlayerPrefs.GetInt("saveLevel");
        Lock = 40;
        if (Key >= Lock)
        {
            SceneManager.LoadScene(40);
            GameManagement.levels = 40;
            SelectOver();
        }
    }

}
