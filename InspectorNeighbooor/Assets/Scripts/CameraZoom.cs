using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    private Variables variables;


    private void Start()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();
        variables.normal = GetComponent<Camera>().fieldOfView;
    }



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            variables.isZoomed = !variables.isZoomed;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            variables.isZoomed = false;
        }
        if (variables.onInspected)
        {

            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, variables.normal, Time.deltaTime * variables.smooth);
        }
        else
        {
            
            if (variables.isZoomed == true)
            {
                GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, variables.zoom, Time.deltaTime * variables.smooth);
            }
            else
            {
                GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, variables.normal, Time.deltaTime * variables.smooth);
            }
        }

    }
}
