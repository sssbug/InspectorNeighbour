using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MouseController : MonoBehaviour
{


    private Variables variables;


    private void Start()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();

    }

    public void Update()
    {
        Mouse();
    }




    private void Mouse()
    {
        variables.playerCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        Ray myRay = variables.playerCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit myRayCastHit;
        if (Input.GetKey(KeyCode.Q))
        {
            variables.mouseLock = false;
            variables.mouseVisible = true;
            variables.screenLock = true;
            variables.MovementLock = true;

            if (Physics.Raycast(myRay, out myRayCastHit, Mathf.Infinity))
            {
                if (myRayCastHit.collider.gameObject.layer == 7 && !variables.onInspected)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        variables.inspected = myRayCastHit.transform.gameObject;
                        variables.originalPos = myRayCastHit.transform.position;
                        variables.originalRot = myRayCastHit.transform.rotation;
                        variables.onInspected = true;
                        variables.orginalScale = myRayCastHit.transform.localScale;
                        if (variables.inspected.GetComponent<Rigidbody>() != null)
                        {
                            myRayCastHit.rigidbody.isKinematic = true;
                        }
                        
                        StartCoroutine(pickupItem());
                    }
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.Q) && variables.onInspected == true)
        {

            StartCoroutine(dropItem());
            variables.mouseLock = true;
            variables.mouseVisible = false;
            variables.screenLock = false;
            variables.MovementLock = false;

            
            if (variables.inspected.GetComponent<Rigidbody>() != null)
            {
                variables.inspected.GetComponent<Rigidbody>().isKinematic = false;
            }
            
            variables.onInspected = false;
        }



        if (Input.GetKeyUp(KeyCode.Q))
        {
            variables.mouseLock = true;
            variables.mouseVisible = false;
            variables.screenLock = false;
            variables.MovementLock = false;
        }

        if (variables.onInspected)
        {
            if (variables.inspected.transform.position == variables.playerSocet.position)
            {
                variables.playerSocet.position = variables.inspected.transform.position;

            }
            else
            {

                variables.inspected.transform.position = Vector3.Lerp(variables.inspected.transform.position, variables.playerSocet.position, 0.2f);
            }
            if (Physics.Raycast(myRay, out myRayCastHit, Mathf.Infinity))
            {
                if (Input.GetMouseButton(1))
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (myRayCastHit.collider.gameObject.layer == 8)
                        {
                            
                            Destroy(myRayCastHit.collider.gameObject);
                        }
                    }
                }
                else
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        variables.lastFrameMousePosX = Input.mousePosition.x;
                        variables.lastFrameMousePosY = Input.mousePosition.y;
                    }
                    if (Input.GetMouseButton(0))
                    {

                        float _inputDifferenceY = Input.mousePosition.x - variables.lastFrameMousePosX;
                        float _inputDifferenceX = Input.mousePosition.y - variables.lastFrameMousePosY;
                        variables.rotationY = Quaternion.Euler(0f, _inputDifferenceY * variables.sensitivity * Time.deltaTime, -_inputDifferenceX * variables.sensitivity * Time.deltaTime);
                        variables.lastFrameMousePosX = Input.mousePosition.x;
                        variables.lastFrameMousePosY = Input.mousePosition.y;

                    }

                    if (Input.GetMouseButtonUp(0))
                    {

                        variables.rotationY = Quaternion.Euler(0f, 0f, 0f);

                    }
                }
            }
            variables.playerSocet.transform.rotation = variables.rotationY * variables.playerSocet.transform.rotation;

        }
        else if (variables.inspected != null)
        {
           
            variables.inspected.transform.SetParent(null);
            variables.inspected.transform.position = Vector3.Lerp(variables.inspected.transform.position, variables.originalPos, 0.2f);
            variables.inspected.transform.rotation = Quaternion.Euler(variables.originalRot.x, variables.originalRot.y, -90);
        }

        if (Physics.Raycast(myRay, out myRayCastHit, 5))
        {
            // E tusunu kapat
            if (myRayCastHit.collider.gameObject.layer == 10)
            {
                if (Input.GetKeyDown(KeyCode.X))
                {

                    variables.pinClone = Instantiate(variables.pin, myRayCastHit.point + new Vector3(-.1f,0,0), Quaternion.identity);
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
    IEnumerator pickupItem()
    {
        variables.inspected.transform.localScale = variables.orginalScale;
        // burada haraketi kapat
        yield return new WaitForSeconds(0.2f);
        variables.inspected.transform.SetParent(variables.playerSocet);
    }


    IEnumerator dropItem()
    {


        yield return new WaitForSeconds(0.2f);
        // burada haraketi ac
    }



}
