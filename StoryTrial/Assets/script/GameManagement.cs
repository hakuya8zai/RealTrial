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
        levels = 0;
        Time.timeScale = 1.0f;
        topScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (RotateAround.GG == true)
        {
            Reload();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {

            SceneManager.LoadScene(levels);

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
        SceneManager.LoadScene(levels);
    }


}
