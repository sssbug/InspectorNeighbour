using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PinController : MonoBehaviour
{


    private Variables variables;


    private void Start()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();

    }

    public void Update()
    {
        Pin();
    }




    private void Pin()
    {
        variables.playerCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        Ray myRay = variables.playerCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit myRayCastHit;
        
        if (Physics.Raycast(myRay, out myRayCastHit, 5))
        {
            // E tusunu kapat
            if (myRayCastHit.collider.gameObject.layer == 10)
            {
                if (Input.GetKeyDown(KeyCode.X))
                {

                    variables.pinClone = Instantiate(variables.pin, myRayCastHit.point + new Vector3(-.1f, 0, 0), Quaternion.identity);
                    variables.pinClone.transform.localRotation = Quaternion.Euler(0, 180, 0);

                }
                if (Input.GetKey(KeyCode.X))
                {
                    if (!variables.pinClone)
                    {
                        variables.pinClone = Instantiate(variables.pin, myRayCastHit.point + new Vector3(-.1f, 0, 0), Quaternion.identity);
                        variables.pinClone.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    }
                    variables.pinClone.transform.position = myRayCastHit.point + new Vector3(-.06f, 0, 0);

                }
                if (Input.GetKeyUp(KeyCode.X))
                {
                    if (myRayCastHit.collider.gameObject.layer != 6)
                    {

                        variables.pinList.Add(variables.pinClone);
                        variables.album.SetActive(true);
                        variables.album.transform.position = myRayCastHit.point + new Vector3(0.2f, -.3f, .6f);
                        variables.mouseLock = false;
                        variables.mouseVisible = true;
                        variables.screenLock = true;
                        variables.MovementLock = true;
                    }
                }

            }

        }
    }
    



}
