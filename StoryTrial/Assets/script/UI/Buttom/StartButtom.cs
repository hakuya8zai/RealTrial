using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtom : MonoBehaviour {
    public GameObject selection;
    public GameObject StartCanvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartEvent()
    {
        selection.SetActive(true);
        StartCanvas.SetActive(false);
    }
    public void ContinueEvent()
    {
        GameManagement.Reload();
    }
}
