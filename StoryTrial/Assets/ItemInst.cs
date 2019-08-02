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

    // Start is called before the first frame update
    private void Awake()
    {
        DifLevel = 5;
    }

    void Start()
    {
        InvokeRepeating(("RayTest"), 0.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
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
        if (a.name != ("chosen") && a != null)
        {
            print(a);
            a.name = ("chosen");

            if(DifLevel == 0)
            {
                a.AddComponent<ChangeTurningWay>();
            }
            else if(DifLevel == 1)
            {
                int s = 0;
                s = Random.Range(1, 5);
                if (s <= 2)
                { a.AddComponent<ChangeTurningWay>(); }
                else if (s == 3)
                { a.AddComponent<TurningSlower>(); }
                else if(s==4)
                { a.AddComponent<TurningFaster>(); }
            }
            else if(DifLevel ==2)
            {
                int s = 0;
                s = Random.Range(1, 7);
                if (s <= 2)
                { a.AddComponent<ChangeTurningWay>(); }
                else if (s == 3||s==4)
                { a.AddComponent<TurningSlower>(); }
                else if (s >=5)
                { a.AddComponent<TurningFaster>(); }
            }
            else if (DifLevel == 3)
            {
                int s = 0;
                s = Random.Range(1, 7);
                if (s <= 3)
                { a.AddComponent<ChangeTurningWay>(); }
                else if ( s == 4)
                { a.AddComponent<TurningSlower>(); }
                else if (s >= 5)
                { a.AddComponent<TurningFaster>(); }
            }
            else if (DifLevel ==4)
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
            else if (DifLevel ==5)
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
