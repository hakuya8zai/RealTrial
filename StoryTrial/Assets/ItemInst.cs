using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInst : MonoBehaviour
{
    public GameObject[] theRange = new GameObject[16];
    Ray bilibili;
    RaycastHit biliItem;
    public int ItemNumber=1;
    public int DifLevel = 0;
    public float BornSpeed = 15.0f;
    public Material theMaterial;

    // Start is called before the first frame update
    private void Awake()
    {

    }

    void Start()
    {

        for (int i = 0; i <= 15; i++)
        { theRange[i] = null; }

        InvokeRepeating(("RayTest"), 2.0f, BornSpeed);

    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreManage.score <= 50)
        { DifLevel = 0;
            ItemNumber = 1;
            BornSpeed = 25.0f;
        }
        else if (ScoreManage.score <= 100 && ScoreManage.score > 50)
        { DifLevel = 0;
            ItemNumber = 3;
            BornSpeed = 25.0f;
        }
        else if (ScoreManage.score <= 150 && ScoreManage.score > 100)
        { DifLevel = 1 ;
            ItemNumber = 1;
            BornSpeed = 20.0f;
        }
        else if(ScoreManage.score <= 200 && ScoreManage.score > 150)
        { DifLevel = 1;
            ItemNumber = 3;
            BornSpeed = 20.0f;
        }
        else if(ScoreManage.score <= 250 && ScoreManage.score > 200)
        { DifLevel = 1;
            ItemNumber = 2;
            BornSpeed = 15.0f;
        }
        else if(ScoreManage.score <= 300 && ScoreManage.score > 250)
        { DifLevel = 1;
            ItemNumber = 1;
            BornSpeed = 10.0f;
        }
        else if (ScoreManage.score <= 450 && ScoreManage.score > 300)
        { DifLevel = 2;
            ItemNumber = 1;
            BornSpeed = 5.0f;
        }
        else if (ScoreManage.score <= 500 && ScoreManage.score > 450)
        { DifLevel = 2;
            ItemNumber = 3;
            BornSpeed = 5.0f;
        }
        else if (ScoreManage.score <= 550 && ScoreManage.score > 500)
        { DifLevel = 2;
            ItemNumber = 1;
            BornSpeed = 5.0f;
        }
        else if (ScoreManage.score <= 600 && ScoreManage.score > 550)
        { DifLevel = 2; }
        else if (ScoreManage.score <= 650 && ScoreManage.score > 600)
        { DifLevel = 2; }
        else if (ScoreManage.score <= 700 && ScoreManage.score > 650)
        { DifLevel = 2; }
        else if (ScoreManage.score <= 750 && ScoreManage.score > 700)
        { DifLevel = 3; }
        else if (ScoreManage.score <= 800 && ScoreManage.score > 750)
        { DifLevel = 3; }
        else if (ScoreManage.score <= 850 && ScoreManage.score > 800)
        { DifLevel = 3; }
        else if (ScoreManage.score <= 900 && ScoreManage.score > 850)
        { DifLevel = 3; }
        else if (ScoreManage.score <= 950 && ScoreManage.score > 900)
        { DifLevel = 5; }
        else if (ScoreManage.score <= 1000 && ScoreManage.score > 950)
        { DifLevel = 5; }
        else if(ScoreManage.score > 1000)
        { DifLevel = 5; }
        
    }

    void RayTest()
    {
        int i = 0;
        for(int y = 0;y<=3;y++)
        {
            for(int x = 0; x < 4; x++)
            {
                bilibili = new Ray(new Vector3(-4.5f+x*3, (CameraFollow.target.transform.position.y + 9) + 3 * y, 1),new Vector3(0,0,-1));
                if(Physics.Raycast(bilibili,out biliItem)==true)
                {
                    theRange[i] = biliItem.collider.gameObject;
                    
                }
                i++;
            }
            
        }
        for(int b = 0; b < ItemNumber; b++)
        {

            ChooseOne();
        }

    }

    void ChooseOne()
    {
        GameObject a;
        a = theRange[Random.Range(0, theRange.Length)];

        if (a == null)
        {
            ChooseOne();
        }
        else if(a!=null)
        {
            if (a.name != ("chosen"))
            {
                a.name = ("chosen");

                Renderer skin = a.GetComponent<Renderer>();
                skin.material = theMaterial;

                if (DifLevel == 0)
                {
                    a.AddComponent<ChangeTurningWay>();
                }
                else if (DifLevel == 1)
                {
                    int s = 0;
                    s = Random.Range(1, 5);
                    if (s <= 2)
                    { a.AddComponent<ChangeTurningWay>(); }
                    else if (s == 3)
                    { a.AddComponent<TurningSlower>(); }
                    else if (s == 4)
                    { a.AddComponent<TurningFaster>(); }
                }
                else if (DifLevel == 2)
                {
                    int s = 0;
                    s = Random.Range(1, 7);
                    if (s <= 2)
                    { a.AddComponent<ChangeTurningWay>(); }
                    else if (s == 3 || s == 4)
                    { a.AddComponent<TurningSlower>(); }
                    else if (s >= 5)
                    { a.AddComponent<TurningFaster>(); }
                }
                else if (DifLevel == 3)
                {
                    int s = 0;
                    s = Random.Range(1, 7);
                    if (s <= 3)
                    { a.AddComponent<ChangeTurningWay>(); }
                    else if (s == 4)
                    { a.AddComponent<TurningSlower>(); }
                    else if (s >= 5)
                    { a.AddComponent<TurningFaster>(); }
                }
                else if (DifLevel == 4)
                {
                    int s = 0;
                    s = Random.Range(1, 5);
                    if (s <= 1)
                    { a.AddComponent<ChangeTurningWay>(); }
                    else if (s == 2)
                    { a.AddComponent<TurningSlower>(); }
                    else if (s >= 3)
                    { a.AddComponent<TurningFaster>(); }
                }
                else if (DifLevel == 5)
                {
                    int s = 0;
                    s = Random.Range(1, 7);
                    if (s <= 1)
                    { a.AddComponent<ChangeTurningWay>(); }
                    else if (s == 3 || s == 2)
                    { a.AddComponent<TurningSlower>(); }
                    else if (s >= 4)
                    { a.AddComponent<TurningFaster>(); }
                }

            }
            else
            {
                ChooseOne();
            }
        }


    }



}
