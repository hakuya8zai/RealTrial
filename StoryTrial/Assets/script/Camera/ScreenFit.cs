using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFit : MonoBehaviour
{
    public float aspectRatio = 9f / 16f;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float scale = screenRatio / aspectRatio;

        if(scale > 1f)
        {
            Rect pixRect = cam.pixelRect;

            pixRect.width = pixRect.height * aspectRatio;
            pixRect.y = 0f;

            pixRect.x = ((float)Screen.width - pixRect.width) / 2f;
            cam.pixelRect = pixRect;

        }
        else
        {
            Rect pixRect = cam.pixelRect;

            pixRect.height = pixRect.width / aspectRatio;
            pixRect.x = 0f;

            pixRect.y = ((float)Screen.height - pixRect.height) / 2f;

            cam.pixelRect = pixRect;
        }
    }
}
