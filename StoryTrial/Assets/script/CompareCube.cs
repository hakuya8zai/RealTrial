using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareCube : MonoBehaviour {

    public Renderer skin;
    public Material offskin;
    // Use this for initialization

    private void Awake()
    {
        skin = GetComponent<Renderer>();
        this.gameObject.tag = ("unfill");
    }
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (this.CompareTag("filled"))
        {
            skin.material = new Material(offskin);
        }
        else
        {

        }
	}


    




}
