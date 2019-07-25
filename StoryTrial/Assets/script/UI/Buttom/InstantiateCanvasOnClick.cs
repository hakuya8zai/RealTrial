using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCanvasOnClick : MonoBehaviour {

    public GameObject PauseCanvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickEvent()
    {
        GameManagement.OnEnable();
        PauseCanvas.SetActive(true);
    }
}
