using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public static Transform target;
    public GameObject board;
    public static float smoothTime = 0.4f;
    private Vector3 cameraVelocity = Vector3.zero;
    private Camera mainCamera;
    public bool Mode = true;

    // Use this for initialization
    void Start()
    {
        smoothTime = 1.0f;
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
        ///if (Input.GetKeyDown(KeyCode.Space))
        ///{
        ///    transform.position = Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, transform.position.y, -9), ref cameraVelocity, smoothTimeToo);
        ///}
        if (Mode == false)
        {
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3((target.position.x + board.transform.position.x) / 2, (target.position.y + board.transform.position.y) / 2, target.position.z - 10), ref cameraVelocity, smoothTime);
        }

        else if (Mode == true)
        {
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(target.position.x/3, target.position.y + 12, target.position.z - 10), ref cameraVelocity, smoothTime);
        }

    }

    
}