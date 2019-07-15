using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFollow : MonoBehaviour {

    
    private Camera cam;
    public Text theySay;
    private float offsetX;
    private float offsetY;
    private float smoothTime = 0.2f;
    private Vector3 cameraVelocity = Vector3.zero;

	// Use this for initialization
	void Start () {
        cam = Camera.main;
        offsetX = 600.0f;
        offsetY = -150.0f;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 screenPos = cam.WorldToScreenPoint(CameraFollow.target.position) + new Vector3(offsetX, offsetY, 0);
        theySay.rectTransform.position = Vector3.SmoothDamp(theySay.rectTransform.position,screenPos,ref cameraVelocity,smoothTime);
	}
}
