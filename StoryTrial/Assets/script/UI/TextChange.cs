﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (this.tag == ("filled"))
        {
            UIFollow.theySay.text = ("yaaaaaaaa");
        }
    }
}
