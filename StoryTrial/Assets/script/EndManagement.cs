using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EndManagement : MonoBehaviour {
    public GameObject[] boards = new GameObject[3];
    public GameObject[] end = new GameObject[1];
    private int s = 0;
    // Use this for initialization
    void Start () {
        BornTweenA();
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

    public void BornTweenA()
    {
        for (int i = 0; i < boards.Length; i++)
        {
            boards[i].transform.localScale = new Vector3(0, 0, 0);
        }
        BornTweenB();
    }

    public void BornTweenB()
    {
        for (int s = 0; s < boards.Length; s++)
        {
            boards[s].transform.DOScale(new Vector3(2.5f,2.5f,0.1f), 0.1f);
        }
        Invoke("BornTweenC", 0.1f);
    }
    public void BornTweenC()
    {
        for (int b = 0; b < boards.Length; b++)
        {
            boards[b].transform.DOShakeScale(1.0f, new Vector3(3, 2, 0.1f));
        }
    }
}
