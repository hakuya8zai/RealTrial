using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

    public int zoomIn = 90;
    public int zoomNone = 120;
    public float smooth = 0.0001f;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating(("ZoomInTo"), 0.0f, 0.00002f);
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {

            InvokeRepeating(("ZoomOutTo"), 0.0f, 0.00002f);
        }

	}

    public void ZoomInTo()
    {

        GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoomIn, Time.deltaTime * smooth);
    }
    public void ZoomOutTO()
    {

        GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoomNone, Time.deltaTime * smooth);
    }



}
