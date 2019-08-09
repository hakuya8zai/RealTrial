using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

    public static GameObject FirstManagement;
    // Use this for initialization
    private void Awake()
    {
        if(FirstManagement == null)
        {
            GameManagement.levels = 0;
            print("LoadFirstScene");
            FirstManagement = this.gameObject;
            DontDestroyOnLoad(this.gameObject);
            AdTest.adsCount = 5;
            PlayerPrefs.SetInt("HP", AdTest.adsCount);

        }
        else if (FirstManagement != null)
        {
            print("Destroy");
            Destroy(this.gameObject);
        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
