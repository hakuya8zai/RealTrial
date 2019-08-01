using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AIManager : MonoBehaviour
{
    public GameObject theMonster;
    public GameObject[] theRange;
    public int ArrayLong;
    int i = 0;
    int s = 1;
    Ray AIRay;
    RaycastHit AIhit;
    public bool circle = false;
    public bool goback= false;
    
    // Start is called before the first frame update
    void Start()
    {
        if(circle == true)
        {
            InvokeRepeating("MonsterMoveCircle", 1.0f, 1.5f);
        }
        else if (goback == true)
        {
            InvokeRepeating("MonsterMove", 1.0f, 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        AIRay = new Ray(theMonster.transform.position, new Vector3(0, 0, 1));
        
        if(Physics.Raycast(AIRay,out AIhit) == true)
        {
            if (AIhit.collider.CompareTag("side"))
            {
                DeadBodyManager.DeadPos = AIhit.transform.position;
                DeadBodyManager.DeadRotation = AIhit.transform.rotation;
                DeadBodyManager.blackBorn = true;
                RotateAround.GG = true;
            }
            else if (AIhit.collider.CompareTag("core"))
            {
                DeadBodyManager.DeadPos = AIhit.transform.position;
                DeadBodyManager.DeadRotation = AIhit.transform.rotation;
                DeadBodyManager.whiteBorn = true;
                RotateAround.GG = true;
            }
        }

    }

    void MonsterMove()
    {
        if (i ==0)
        {
            s = 1;
        }
        else if (i == 3)
        {
            s = -1 ;
        }

        theMonster.transform.DOMove(new Vector3(theRange[i].transform.position.x, theRange[i].transform.position.y, theMonster.transform.position.z), 0.3f);
        i = i + s;


    }

    void MonsterMoveCircle()
    {
        if(i > ArrayLong-1)
        {
            i = 0;
            s = 1;
        }
        theMonster.transform.DOMove(new Vector3(theRange[i].transform.position.x, theRange[i].transform.position.y, theMonster.transform.position.z), 0.3f);
        i = i + s;

    }
}
