using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    private Variables variables;


    private void Start()
    {
        variables = GameObject.Find("VariablesController").GetComponent<Variables>();
    }



    private void Update()
    {

        Pick();



    }

    private void Pick()
    {

        if (!variables.delOpen)
        {
            variables.playerCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
            Ray myRay = variables.playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRayCastHit;


            if (Input.GetKeyDown(KeyCode.Q))
            {
                variables.pickUpOpen = !variables.pickUpOpen;
                variables.pickUpClose = !variables.pickUpClose;
            }




            if (variables.pickUpOpen == true)
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
                            variables.AddButton.SetActive(true);
                            if (variables.onInspected)
                            {
                                variables.inspected.GetComponent<Collider>().enabled = false;
                            }


                            StartCoroutine(pickupItem());
                        }
                    }
                }

            }
            else if (variables.onInspected == true && variables.pickUpClose == true)
            {

                StartCoroutine(dropItem());
                variables.mouseLock = true;
                variables.mouseVisible = false;
                variables.screenLock = false;
                variables.MovementLock = false;


                

                variables.onInspected = false;
            }



            if (variables.pickUpClose == true)
            {
                if (variables.onInspected)
                {
                    variables.inspected.GetComponent<Collider>().isTrigger = false;
                }
                variables.AddButton.SetActive(false);
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
                            if (myRayCastHit.collider.gameObject.layer == 8 /*BookLayer*/)
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
                variables.inspected.transform.position = variables.originalPos;
                variables.inspected.transform.rotation = Quaternion.Euler(variables.originalRot.x, variables.originalRot.y, -90);
                variables.inspected.GetComponent<Collider>().enabled = true;
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
