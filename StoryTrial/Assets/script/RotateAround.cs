using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateAround : MonoBehaviour {
    public GameObject coreCube;
    public GameObject sideCube;
    public static float turnSpeed;
    public bool origin = true;
    public int n = 0;

    Ray coreRay;
    Ray sideRay;
    RaycastHit sideHit;
    RaycastHit coreHit;
    public static bool GG = false;



    // Use this for initialization
    private void Awake()
    {

    }

    void Start () {
        CameraFollow.target = coreCube.transform;
        coreCube.tag = ("core");
        sideCube.tag = ("side");
        GG = false;
        turnSpeed = 80.0f;

        InvokeRepeating("SideTurn", 1.0f, 0.000011f);
    }
	
	// Update is called once per frame
	void Update () {


        coreRay = new Ray(coreCube.transform.position, new Vector3(0, 0, 1));
        sideRay = new Ray(sideCube.transform.position, new Vector3(0, 0, 1));

        

            if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
            {

            if (EventSystem.current.IsPointerOverGameObject())
            {
                Debug.Log("onUI");
            }
            else
            {
                Debug.Log("onObject");


                if (Physics.Raycast(sideRay, out sideHit) == true && origin == true)
                {
                    Invoke("CoreJudge", 0.0f);
                    CameraFollow.target = sideCube.transform;
                    CancelInvoke("SideTurn");
                    InvokeRepeating("CoreTurn", 0.0f, 0.000011f);

                }
                else if (Physics.Raycast(coreRay, out coreHit) == true && origin == false)
                {
                    Invoke("SideJudge", 0.0f);
                    CameraFollow.target = coreCube.transform;
                    CancelInvoke("CoreTurn");
                    InvokeRepeating("SideTurn", 0.0f, 0.000011f);

                }
                else
                {
                    GG = true;
                }
            }


            }
            


        
        

        


    }




    public void CoreTurn()
    {
        coreCube.transform.RotateAround(sideCube.transform.position,new Vector3(0,0,ChangeTurningWay.turningWay), turnSpeed * Time.deltaTime);
    }

    public void SideTurn()
    {
        sideCube.transform.RotateAround(coreCube.transform.position,new Vector3(0,0, ChangeTurningWay.turningWay), turnSpeed * Time.deltaTime);
    }

    public void CoreJudge()
    {///core開始轉前同時
        origin = false;
        coreCube.tag = ("side");
        sideCube.tag = ("core");
        if(sideHit.collider.gameObject.CompareTag("unfill"))
        {
            sideCube.transform.position = new Vector3(sideHit.transform.position.x, sideHit.transform.position.y, sideCube.transform.position.z);
            CubeReturn();
            sideHit.collider.gameObject.tag = ("filled");

        }
        else if (sideHit.collider.gameObject.CompareTag("filled"))
        {
            GG = true;
        }
        else if (sideHit.collider.gameObject.CompareTag("End"))
        {
            sideHit.collider.gameObject.tag = ("Ended");
        }
        else
        {
            GG = true;
        }

    }

    public void SideJudge()
    {///side開始轉前同時
        origin = true;
        sideCube.tag = ("side");
        coreCube.tag = ("core");
        if(coreHit.collider.gameObject.CompareTag("filled") )
        {
            GG = true;
        }
        else if(coreHit.collider.gameObject.CompareTag("unfill"))
        {

            coreCube.transform.position = new Vector3(coreHit.transform.position.x, coreHit.transform.position.y, coreCube.transform.position.z);
            CubeReturn();
            coreHit.collider.gameObject.tag = ("filled");

        }
        else if (coreHit.collider.gameObject.CompareTag("End"))
        {
            coreHit.collider.gameObject.tag = ("Ended");
        }
        else
        {
            GG = true;
        }


    }

    public void CubeReturn()
    {
        Quaternion returnRotation =new  Quaternion();
        returnRotation.eulerAngles = new Vector3(0, 0, 0);
        if(origin == true)
        {
            coreCube.transform.rotation = returnRotation;
        }
        else if (origin == false)
        {
            sideCube.transform.rotation = returnRotation;
        }

    }




}
