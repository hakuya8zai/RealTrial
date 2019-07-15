using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningSlower : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        this.gameObject.GetComponent<TurningSlower>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.CompareTag("filled"))
        {
            Invoke(("ChangeAndStop"), 0.0f);
        }
    }


    void ChangeAndStop()
    {
        RotateAround.turnSpeed = 40.0f;
        this.gameObject.GetComponent<TurningSlower>().enabled = false;
    }
}
