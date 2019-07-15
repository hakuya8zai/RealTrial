using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeverTimeManagement : MonoBehaviour {
    public static int FeverPower = 0;
    public static bool FeverMode = false;
    public GameObject feverFilter;

    public static int n;
    // Use this for initialization
    void Start () {
        n = 1;
        FeverPower = 0;
        InvokeRepeating("FeverDown", 0.0f, 1.0f);
        FeverMode = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (FeverPower >= 200000)
        {
            feverFilter.SetActive(true);
            FeverMode = true;
        }
        else if(FeverPower <= 0)
        {
            feverFilter.SetActive(false);
            FeverMode = false;
            FeverPower = 0;
        }
	}

    void FeverDown()
    {
        if(FeverMode == true)
        {
            n = 5;
        }
        else if (FeverMode == false)
        {
            n = 1;
        }
        if (FeverPower > 0)
        {
            FeverPower = FeverPower-n;
        }
        print(FeverPower);
    }


    public static void FeverUp()
    {
        if (FeverMode == false)
        {
            FeverPower = FeverPower + 2;
 

        }
    }



}
