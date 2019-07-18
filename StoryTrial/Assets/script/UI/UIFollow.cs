using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIFollow : MonoBehaviour {

    
    private Camera cam;
    public static Text theySay;
    private float offsetX = 600.0f;
    private float offsetY = -150.0f;
    private float smoothTime = 1.0f;
    private Vector3 cameraVelocity = Vector3.zero;


    // Use this for initialization
    private void Awake()
    {
        theySay = GetComponent<Text>();
    }
    void Start () {
        cam = Camera.main;
        Vector3 screenPos = cam.WorldToScreenPoint(CameraFollow.target.position) + new Vector3(offsetX, offsetY, 0);
        theySay.rectTransform.position = screenPos;
}
	
	// Update is called once per frame
	void Update () {
        Vector3 screenPos = cam.WorldToScreenPoint(CameraFollow.target.position) + new Vector3(offsetX, offsetY, 0);
        theySay.rectTransform.position = Vector3.SmoothDamp(theySay.rectTransform.position,screenPos,ref cameraVelocity,smoothTime);
	}

    public static void TextFadeIn()
    {

        theySay.CrossFadeAlpha(225, 0.0f, false);

    }
    public static void TextFadeOut()
    {
        theySay.CrossFadeAlpha(0, 0.0f, false);
    }
}
