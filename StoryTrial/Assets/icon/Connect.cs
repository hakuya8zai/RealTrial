using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Connect : MonoBehaviour
{
    public GameObject SettingCanvas;
    private bool sound = true;
    private bool music = true;

    public GameObject soundOn;
    public GameObject soundOff;

    public GameObject musicOn;
    public GameObject musicOff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/forced_gamedev/?hl=zh-tw");
    }

    public void Facebook()
    {
        Application.OpenURL("https://business.facebook.com/%E6%9C%89%E4%BA%BA%E6%8B%BF%E6%A7%8D%E9%80%BC%E6%88%91%E5%81%9A%E9%81%8A%E6%88%B2-110213430319795/?modal=admin_todo_tour");
    }

    public void Back()
    {
        UIManager.UIOpen = false;
        SettingCanvas.SetActive(false);
        GameManagement.OnDisable();
    }

    public void Home()
    {
        UIManager.UIOpen = false;
        SettingCanvas.SetActive(false);
        GameManagement.OnDisable();
        SceneManager.LoadScene(0);
        UIManager.theStartCanvas.SetActive(true);
        DeadBodyManager.BodyCount = 0;
        SelectButtoms.theHelpCanvas.SetActive(false);
        SelectButtoms.thePlayingCanvas.SetActive(false);
    }
    public void Volume()
    {
        if(sound == true)
        {
            sound = false;
            soundOff.SetActive(false);
            soundOn.SetActive(true);
            TouchSound.playAudio = true;

            TouchSound.theBGM.volume = 0.5f;
            TouchSound.theBeatOne.volume = 0.6f;
            TouchSound.theBeatTwo.volume = 1.0f;
        }
        else if(sound == false)
        {
            sound = true;
            soundOn.SetActive(false);
            soundOff.SetActive(true);
            TouchSound.theBGM.volume = 0.0f;
            TouchSound.theBeatOne.volume = 0.0f;
            TouchSound.theBeatTwo.volume = 0.0f;
        }

    }
    public void Music()
    {
        if(music == true)
        {
            music = false;
            TouchSound.theBGM.volume = 0.5f;
            musicOff.SetActive(false);
            musicOn.SetActive(true);
        }
        else if(music == false)
        {
            music = true;
            TouchSound.theBGM.volume = 0.0f;
            musicOn.SetActive(false);
            musicOff.SetActive(true);
        }
    }
}
