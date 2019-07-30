using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBodyManager : MonoBehaviour
{
    public static GameObject[] CubeBody = new GameObject[20];
    public GameObject blackBody;
    public GameObject whiteBody;
    public static int BodyCount = 0;
    GameObject transBody;
    public static Vector3 DeadPos;
    public static Quaternion DeadRotation;
    public static bool blackBorn = false;
    public static bool whiteBorn = false;


    // Start is called before the first frame update
    void Start()
    {
        
        blackBorn = false;
        whiteBorn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(whiteBorn == true)
        {
            InstWhiteBody();
            whiteBorn = false;
        }
        if(blackBorn == true)
        {
            InstBlackBody();
            blackBorn = false;
        }
        

        
    }

    public void InstWhiteBody()
    {
        CubeBody[BodyCount] = (Instantiate(whiteBody, DeadPos, DeadRotation) as GameObject);
        CubeBody[BodyCount].transform.parent = this.gameObject.transform;


        BodyCount++;
    }
    public void InstBlackBody()
    {
        CubeBody[BodyCount] = (Instantiate(blackBody, DeadPos, DeadRotation)as GameObject);
        CubeBody[BodyCount].transform.parent = this.gameObject.transform;
        
        BodyCount++;
    }
    public static void ClearBody()
    {

        for(int i = 0; i <= 19; i++)
        {
            Destroy(CubeBody[i]);
            CubeBody[i] = null;
        }
        BodyCount = 0;
    }

    
}
