using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private Variables variables;


    private void Start()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();

        
    }

    

    private void Update()
    {
        Cursor.lockState = variables.mouseLock ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = variables.mouseVisible;

        if (!variables.screenLock)
        {
            float mouseX = Input.GetAxis("Mouse X") * variables.mouseSensivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * variables.mouseSensivity * Time.deltaTime;

            

            variables.xRotation -= mouseY;
            variables.xRotation = Mathf.Clamp(variables.xRotation, -90f, 90);

            transform.localRotation = Quaternion.Euler(variables.xRotation, 0, 0);
            variables.playerBody.transform.Rotate(Vector3.up * mouseX);
        }
        
    }
}
