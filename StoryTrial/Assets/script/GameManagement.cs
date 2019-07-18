using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour {

    public GameObject topScreen;
    // Use this for initialization
    public GameObject FeverScreen;

    void Start() {
        Time.timeScale = 1.0f;
        topScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (RotateAround.GG == true)
        {
            TimeBreak();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {

            SceneManager.LoadScene(0);

        }




    }

    public void TimeBreak()
    {
        Time.timeScale = 0f;
        topScreen.SetActive(true);
    }


}
