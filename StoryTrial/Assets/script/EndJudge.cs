using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndJudge : MonoBehaviour {
    public static int Level;
	// Use this for initialization
	void Start () {
        Level = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.CompareTag("End"))
        {

        }
        else if (this.CompareTag("Ended"))
        {
            SceneManager.LoadScene(Level);
        }



	}
}
