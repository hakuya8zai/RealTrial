using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        InvokeRepeating("SideTurn", 0.0f, 0.00002f);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            FeverTimeManagement.FeverPower = 40;
        }

        coreRay = new Ray(coreCube.transform.position, new Vector3(0, 0, 1));
        sideRay = new Ray(sideCube.transform.position, new Vector3(0, 0, 1));

        if (FeverTimeManagement.FeverMode == false)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {


                if (Physics.Raycast(sideRay, out sideHit) == true && origin == true)
                {
                    Invoke("CoreJudge", 0.0f);
                    FeverTimeManagement.FeverUp();
                    CameraFollow.target = sideCube.transform;
                    CancelInvoke("SideTurn");
                    InvokeRepeating("CoreTurn", 0.0f, 0.00002f);

                }
                else if (Physics.Raycast(coreRay, out coreHit) == true && origin == false)
                {
                    Invoke("SideJudge", 0.0f);
                    CameraFollow.target = coreCube.transform;
                    FeverTimeManagement.FeverUp();
                    CancelInvoke("CoreTurn");
                    InvokeRepeating("SideTurn", 0.0f, 0.00002f);

                }
                else
                {
                    GG = true;
                }

            }
            


        }
        else if (FeverTimeManagement.FeverMode == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                InvokeRepeating(("FeverPlay"), 0.0f, 0.2f);
            }
            else if (Input.GetKeyUp(KeyCode.F))
            {
                CancelInvoke("FeverPlay");
            }
        }


    }


    public void FeverPlay()
    {
        int cubeNumber = 0;
        string cubeName = System.Convert.ToString(cubeNumber);


        GameObject theNext;
        if (origin == true && Physics.Raycast(coreRay, out coreHit) == true)
        {

            for (int i = n; i <= 1000; i++)
            {
                cubeNumber = i;
                cubeName = System.Convert.ToString(cubeNumber);
                if (cubeName == coreHit.collider.name)
                {
                    cubeNumber++;
                    cubeName = System.Convert.ToString(cubeNumber);
                    theNext = GameObject.Find(cubeName);
                    coreCube.transform.position = new Vector3(theNext.transform.position.x, theNext.transform.position.y, coreCube.transform.position.z);
                    SideTurn();
                    CubeReturn();
                    theNext.gameObject.tag = ("filled");
                    n = cubeNumber;
                    break;

                }


            }


        }
        else if (origin == false && Physics.Raycast(sideRay, out sideHit) == true)
        {
            for (int i = n; i <= 1000; i++)
            {
                cubeNumber = i;
                cubeName = System.Convert.ToString(cubeNumber);
                if (cubeName == sideHit.collider.name)
                {
                    cubeNumber++;
                    cubeName = System.Convert.ToString(cubeNumber);
                    theNext = GameObject.Find(cubeName);
                    sideCube.transform.position = new Vector3(theNext.transform.position.x, theNext.transform.position.y, sideCube.transform.position.z);
                    CoreTurn();
                    CubeReturn();
                    sideHit.collider.gameObject.tag = ("filled");
                    n = cubeNumber;
                    break;

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
        else if (sideHit.collider.gameObject.CompareTag("filled")&&FeverTimeManagement.FeverMode == false)
        {
            GG = true;
        }
        else if(sideHit.collider.gameObject.CompareTag("filled")&&FeverTimeManagement.FeverMode == true)
        {
            sideCube.transform.position = new Vector3(sideHit.transform.position.x, sideHit.transform.position.y, sideCube.transform.position.z);
            CubeReturn();
            sideHit.collider.gameObject.tag = ("filled");
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
        if(coreHit.collider.gameObject.CompareTag("filled") && FeverTimeManagement.FeverMode == false)
        {
            GG = true;
        }
        else if(coreHit.collider.gameObject.CompareTag("unfill"))
        {

            coreCube.transform.position = new Vector3(coreHit.transform.position.x, coreHit.transform.position.y, coreCube.transform.position.z);
            CubeReturn();
            coreHit.collider.gameObject.tag = ("filled");

        }
        else if (coreHit.collider.gameObject.CompareTag("filled") && FeverTimeManagement.FeverMode == true)
        {
            coreCube.transform.position = new Vector3(coreHit.transform.position.x, coreHit.transform.position.y, coreCube.transform.position.z);
            CubeReturn();
            coreHit.collider.gameObject.tag = ("filled");
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
