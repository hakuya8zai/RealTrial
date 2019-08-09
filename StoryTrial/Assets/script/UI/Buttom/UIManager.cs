using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public static bool  UIOpen;


    public GameObject PauseCanvas;
    public GameObject PlayCanvas;
    public GameObject SelectCanvas;
    private GameObject removeObject;
    public GameObject StartCanvas;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {



    }
    public void StartEvent()
    {
        print("shittt");
        UIOpen = true;
        PauseCanvas.SetActive(false);
        SelectCanvas.SetActive(true);
        StartCanvas.SetActive(false);
    }
    public void PauseEvent()
    {
        
        UIOpen = true;
        PauseCanvas.SetActive(true);
    }
    public void ContinueEvent()
    {
        UIOpen = false;
        SelectCanvas.SetActive(false);
        GameManagement.OnDisable();
        PauseCanvas.SetActive(false);
    }


}
