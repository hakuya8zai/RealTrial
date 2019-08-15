using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TutorialManage : MonoBehaviour
{

    public GameObject[] old;
    public GameObject[] theNew;

    public GameObject sideCube;
    public GameObject thePoint;
    Ray touchRay;
    RaycastHit touchRayHit;
    bool complete = true;
    bool start = false;
    public GameObject anchor;

    // Start is called before the first frame update
    void Start()
    {
        thePoint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
        
    {
        touchRay = new Ray(sideCube.transform.position, new Vector3(0, 0, 1));
        if(Physics.Raycast(touchRay, out touchRayHit) == true)
        {
            if (touchRayHit.collider.CompareTag("unfill"))
            {
                if (complete == true)
                {
                    complete = false;
                    thePoint.SetActive(true);
                    Stop();
                    ToMove();
                }
            }
        }



        

        if (this.CompareTag("filled"))
        {

            if (start == false)
            {
                start = true;
                RotateAround.turnSpeed = 80.0f;
                for (int s = 0; s < old.Length; s++)
                {
                    old[s].SetActive(false);

                }
                for (int i = 0; i < theNew.Length; i++)
                {

                    theNew[i].SetActive(true);
                }
                anchor.transform.position = new Vector3(3, 4, 0);

            }



        }

        

    }


    void ToMove()
    {
        thePoint.transform.DOMove(new Vector3(0, -2.5f, 0), 0.4f).From(true);
        Invoke(("Zero"), 0.5f);
        
    }

    void Zero()
    {
        thePoint.SetActive(false);
        complete = true;
        Continue();
    }

    void Stop()
    {
        RotateAround.turnSpeed = 20.0f;

    }
    void Continue()
    {
        RotateAround.turnSpeed = 80.0f;
    }

}
