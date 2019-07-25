using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartEvent()
    {
        GameManagement.Nextload();
    }
    public void ContinueEvent()
    {
        GameManagement.Reload();
    }
}
