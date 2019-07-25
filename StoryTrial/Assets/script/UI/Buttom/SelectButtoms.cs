using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButtoms : MonoBehaviour {
    public GameObject removeObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChapterOneButtom()
    {
        SceneManager.LoadScene(1);
        removeObject.SetActive(false);
    }
}
