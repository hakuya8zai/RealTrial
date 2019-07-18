using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour {


    public  GameObject[] CheckPoint = new GameObject[15];
    public Text theText ;
    private int i = 0;


	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update()
    {

        if (CheckPoint[i].tag == ("filled"))
        {

            theText.text = TextManager.StoryOne[i];
            i = i+1;
        }
    }
}
