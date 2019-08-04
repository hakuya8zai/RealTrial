using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningSlower : MonoBehaviour {

    // Use this for initialization
    bool first = true;
    void Start()
    {
        ///this.gameObject.GetComponent<TurningSlower>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {


        if (first == true)
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
        RotateAround.turnSpeed = RotateAround.turnSpeed - 40.0f;
        ///this.gameObject.GetComponent<TurningSlower>().enabled = false;
    }
}
