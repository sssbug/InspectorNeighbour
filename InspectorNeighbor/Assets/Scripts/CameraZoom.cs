using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    MouseController mouse;
    int zoom = 20;
    int normal = 60;
    float smooth = 5;

    private bool isZoomed = false;

    void Start()
    {
        mouse = GameObject.Find("MouseController").GetComponent<MouseController>();
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isZoomed = !isZoomed;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isZoomed = false;
        }
        if (mouse.onInspected)
        {

            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
        }
        else
        {
            
            if (isZoomed == true)
            {
                GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
            }
            else
            {
                GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
            }
        }

    }
}
