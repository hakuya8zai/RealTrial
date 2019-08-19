using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public static bool  UIOpen;


    public GameObject PauseCanvas;

    public GameObject CheckCanvas;
    public static GameObject theCheckCanvas;
    public GameObject SelectCanvas;
    private GameObject removeObject;
    public GameObject StartCanvas;
    public GameObject SettingCanvas;
    public static GameObject theStartCanvas;
    public static GameObject thePauseCanvas;

    // Use this for initialization
    void Start () {
        theCheckCanvas = CheckCanvas;
        theStartCanvas = StartCanvas;
        thePauseCanvas = PauseCanvas;
    }
	
	// Update is called once per frame
	void Update () {



    }
    public void StartEvent()
    {
        UIOpen = true;
        PauseCanvas.SetActive(false);
        SelectCanvas.SetActive(true);
        StartCanvas.SetActive(false);
    }
    public void SettingEvent()
    {
        UIOpen = true;
        SettingCanvas.SetActive(true);
    }

    public void PauseEvent()
    {
        
        UIOpen = true;
        PauseCanvas.SetActive(true);
    }

    public void CheckEvent()
    {
        CheckCanvas.SetActive(true);
        UIOpen = true;
        GameManagement.OnDisable();
    }

    public void CheckCancel()
    {
        CheckCanvas.SetActive(false);
        UIOpen = false;
        GameManagement.OnEnable();

    }

    public void ContinueEvent()
    {
        UIOpen = false;
        SelectCanvas.SetActive(false);
        GameManagement.OnDisable();
        PauseCanvas.SetActive(false);
    }


}
