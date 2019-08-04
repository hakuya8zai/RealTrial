using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTurningWay : MonoBehaviour {


    public static int turningWay = -1;
    bool first = true;
    // Use this for initialization
    void Start () {
        ///turningWay = -1;
        ///this.gameObject.GetComponent<ChangeTurningWay>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        if(first == true)
        {
            if (this.CompareTag("filled"))
            {

                Invoke(("ChangeAndStop"), 0.0f);
                first = false;
            }
        }

	}


    void ChangeAndStop()
    {
        turningWay = -turningWay;

        ///this.gameObject.GetComponent<ChangeTurningWay>().enabled = false;
    }
}
