using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinJudge : MonoBehaviour
{
    Ray coinRay;
    Ray coinRayUp;
    public GameObject theGhost;
    
    RaycastHit coinHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinRay = new Ray(this.transform.position,new Vector3(0, 0, 1));
        coinRayUp = new Ray(this.transform.position, new Vector3(0, 0, 0 - 1));


        if(Physics.Raycast(coinRay, out coinHit) == true||Physics.Raycast(coinRayUp, out coinHit) == true)
        {
            if (coinHit.collider.CompareTag("side") || coinHit.collider.CompareTag("core"))
            {
                this.gameObject.SetActive(false);
                AdTest.adsCount = 11;
            }

        }



        
    }
}
