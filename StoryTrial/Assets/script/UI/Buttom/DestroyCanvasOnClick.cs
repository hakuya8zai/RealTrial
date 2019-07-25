using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCanvasOnClick : MonoBehaviour {


    public GameObject canvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void ClickEvent()
    {
        GameManagement.OnDisable();
        canvas.SetActive(false);
    }
}
