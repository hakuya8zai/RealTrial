using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class dotest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.localScale = new Vector3(0, 0, 0);
        testa();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            testa();
        }
	}



    private void testa()
    {
        this.transform.DOScale(1,0.1f);
        Invoke("testb", 0.1f);

    }
    private void testb()
    {
        transform.DOShakeScale(0.5f, new Vector3(1, 1, 0));
    }
}
