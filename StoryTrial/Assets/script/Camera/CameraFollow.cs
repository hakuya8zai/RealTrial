using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public static Transform target;
    public GameObject board;
    public static float smoothTime = 0.5f;
    public float smoothTimeToo = 0.1f; 
    private Vector3 cameraVelocity = Vector3.zero;
    private Camera mainCamera;

    // Use this for initialization
    void Start()
    {
        smoothTime = 1.0f;
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position,new Vector3((target.position.x+board.transform.position.x)/2, target.position.y, target.position.z - 10), ref cameraVelocity, smoothTime);
        ///if (Input.GetKeyDown(KeyCode.Space))
        ///{
        ///    transform.position = Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, transform.position.y, -9), ref cameraVelocity, smoothTimeToo);
        ///}
    }

    
}