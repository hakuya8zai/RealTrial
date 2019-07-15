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
        FeverScreen.SetActive(false);
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
        if(FeverTimeManagement.FeverMode == true)
        {
            CameraFollow.smoothTime = 0.5f;
        }
        else if (FeverTimeManagement.FeverMode == false)
        {
            CameraFollow.smoothTime = 1.0f;
        }



    }

    public void TimeBreak()
    {
        Time.timeScale = 0f;
        topScreen.SetActive(true);
    }


}
