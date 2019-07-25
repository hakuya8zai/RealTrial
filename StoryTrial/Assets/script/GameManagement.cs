using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour {

    public GameObject topScreen;
    // Use this for initialization
    public GameObject FeverScreen;
    public static int levels = 0;

    void Start() {
        levels = PlayerPrefs.GetInt("saveLevel");
        Time.timeScale = 1.0f;
        topScreen.SetActive(false);


    }

    // Update is called once per frame
    void Update() {
        if (RotateAround.GG == true)
        {
            Reload();
        }
        if (Input.GetKey(KeyCode.R))
        {
            levels = 0;
            PlayerPrefs.SetInt("saveLevel", levels);
        }





    }

    public void TimeBreak()
    {
        Time.timeScale = 0f;
        topScreen.SetActive(true);
    }

    public static void Reload()
    {
        SceneManager.LoadScene(levels);
    }
    public static void Nextload()
    {
        levels++;
        PlayerPrefs.SetInt("saveLevel",levels);
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
