using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndManagement : MonoBehaviour {
    public GameObject[] boards = new GameObject[3];
    public GameObject[] end = new GameObject[1];
    private int s = 0;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(end[0].CompareTag("filled"))
        {
            print(s);
            if (boards[s].CompareTag("unfill"))
            {
                s = 0;
            }
            else if (boards[s].CompareTag("filled"))
            {
                s++;
            }

            if(s == boards.Length)
            {
                GameManagement.Nextload();
            }


        }

	}
}
