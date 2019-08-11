using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CompareCube : MonoBehaviour {

    public Renderer skin;
    public Material offskin;
    ///public GameObject theLight;
    
    bool first = false;
    // Use this for initialization

    private void Awake()
    {
        first = false;
        skin = GetComponent<Renderer>();
        this.gameObject.tag = ("unfill");
    }
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (first == false)
        {
            if (this.CompareTag("filled"))
            {
                transform.DOShakeScale(0.2f, new Vector3(1, 1, 0));
                skin.material = new Material(offskin);
               /// LightOn();
                BoardsInst.BornCall = true;
                if(this.name == ("chosen"))
                {
                    for(int i = 0; i <= 10; i++)
                    {
                        ScoreManage.ScoreUp();
                    }
                }
                else
                {
                    ScoreManage.ScoreUp();
                }
                first = true;
            }
            
        }








	}

    ///void LightOn()
    ///{
    ///    theLight.SetActive(true);
    ///    Invoke(("LightOff"), 0.3f);
    ///}
    ///void LightOff()
    ///{
    ///    theLight.SetActive(false);
    ///}


    




}
