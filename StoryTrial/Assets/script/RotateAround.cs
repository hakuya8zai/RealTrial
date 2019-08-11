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
    public int _adsCount;

    Ray coreRay;
    Ray sideRay;
    RaycastHit sideHit;
    RaycastHit coreHit;
    public static bool GG = false;


    
    private void Awake()
    {
        turnSpeed = 80.0f;
    }

    void Start () {
        CameraFollow.target = coreCube.transform;
        coreCube.tag = ("core");
        sideCube.tag = ("side");
        GG = false;
        

        InvokeRepeating("SideTurn", 1.0f, 0.000011f);
    }
	
	void Update () {


        coreRay = new Ray(coreCube.transform.position, new Vector3(0, 0, 1));
        sideRay = new Ray(sideCube.transform.position, new Vector3(0, 0, 1));

        if (_adsCount != AdTest.adsCount)
        {
            _adsCount = AdTest.adsCount;
            ResetGhost();
        }

        if (Input.touchCount <= 0) { return; }
        else if (Input.touchCount >= 1)
        {
            

            if (Input.touches[0].phase == TouchPhase.Began)
            {

                TouchSound.playAudio = true;

                if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
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

            if ((sideHit.transform.position - coreCube.transform.position).sqrMagnitude > 9.1f)
            {
                print((sideHit.transform.position - coreCube.transform.position).sqrMagnitude);
                DeadBodyManager.DeadPos = sideCube.transform.position;
                DeadBodyManager.DeadRotation = sideCube.transform.rotation;
                DeadBodyManager.blackBorn = true;
                GG = true;
            }
            else if ((sideHit.transform.position - coreCube.transform.position).sqrMagnitude <= 9.1f)
            {
                sideCube.transform.position = new Vector3(sideHit.transform.position.x, sideHit.transform.position.y, sideCube.transform.position.z);
                CubeReturn();
                sideHit.collider.gameObject.tag = ("filled");
            }


        }
        else if (sideHit.collider.gameObject.CompareTag("filled"))
        {

            DeadBodyManager.DeadPos = sideCube.transform.position;
            DeadBodyManager.DeadRotation = sideCube.transform.rotation;
            DeadBodyManager.blackBorn = true;
            GG = true;
        }
        else if (sideHit.collider.gameObject.CompareTag("End"))
        {
            sideHit.collider.gameObject.tag = ("Ended");
        }
        else
        {
            DeadBodyManager.DeadPos = sideCube.transform.position;
            DeadBodyManager.DeadRotation = sideCube.transform.rotation;
            DeadBodyManager.blackBorn = true;
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
            DeadBodyManager.DeadPos = coreCube.transform.position;
            DeadBodyManager.DeadRotation = coreCube.transform.rotation;
            DeadBodyManager.whiteBorn = true;
            GG = true;
        }
        else if(coreHit.collider.gameObject.CompareTag("unfill"))
        {
            if ((coreHit.transform.position - sideCube.transform.position).sqrMagnitude > 9.1f)
            {
                print((coreHit.transform.position - sideCube.transform.position).sqrMagnitude);
                DeadBodyManager.DeadPos = coreCube.transform.position;
                DeadBodyManager.DeadRotation = coreCube.transform.rotation;
                DeadBodyManager.whiteBorn = true;
                GG = true;
            }
            else if ((coreHit.transform.position - sideCube.transform.position).sqrMagnitude <= 9.1f)
            {
                coreCube.transform.position = new Vector3(coreHit.transform.position.x, coreHit.transform.position.y, coreCube.transform.position.z);
                CubeReturn();
                coreHit.collider.gameObject.tag = ("filled");
            }


        }
        else if (coreHit.collider.gameObject.CompareTag("End"))
        {
            coreHit.collider.gameObject.tag = ("Ended");
        }
        else
        {
            DeadBodyManager.DeadPos = coreCube.transform.position;
            DeadBodyManager.DeadRotation = coreCube.transform.rotation;
            DeadBodyManager.whiteBorn = true;
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

    public void ResetGhost()
    {
        print("Reset");
        coreCube.GetComponent<ActionCode2D.Renderers.SpriteGhostTrailRenderer>().enabled = false;
        sideCube.GetComponent<ActionCode2D.Renderers.SpriteGhostTrailRenderer>().enabled = false;
        coreCube.GetComponent<ActionCode2D.Renderers.SpriteGhostTrailRenderer>().enabled = true;
        sideCube.GetComponent<ActionCode2D.Renderers.SpriteGhostTrailRenderer>().enabled = true;

    }


}
