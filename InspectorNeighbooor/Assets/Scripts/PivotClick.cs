using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotClick : MonoBehaviour
{
    private Variables variables;

    private Transform spawnPosition;
    private GameObject spawned;
    private bool point = true;
    private void OnEnable()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();
        spawnPosition = variables.playerSocet.transform;
    }
    private void Update()
    {
        Dell();
    }
    public void Del()
    {
        variables.pickUpPivot = false;
        point = true;
    }

    private void Dell()
    {
        if (variables.pickUpPivot == false)
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
                if (!variables.onInspectedPivot)
                {
                    variables.mouseLock = false;
                    variables.mouseVisible = true;
                    variables.screenLock = true;
                    variables.MovementLock = true;

                    if (point)
                    {
                        for (int i = 0; i < variables.ObjectList.Count; i++)
                        {


                            if (variables.thisSlott.ItemSlot.item.Name == variables.ObjectList[i].name)
                            {
                                spawned = Instantiate(variables.ObjectList[i], spawnPosition.transform.position, Quaternion.identity);
                                spawned.name = variables.thisSlott.ItemSlot.item.Name;
                                variables.inspectedPivot = spawned.transform.gameObject;
                                variables.originalPos = spawned.transform.position;
                                variables.originalRot = spawned.transform.rotation;
                                variables.onInspectedPivot = true;
                                variables.orginalScale = spawned.transform.localScale;
                                variables.AddButton.SetActive(true);
                                if (variables.onInspectedPivot)
                                {
                                    variables.inspectedPivot.GetComponent<Collider>().enabled = false;
                                }

                                if (variables.inspectedPivot.GetComponent<Rigidbody>() != null)
                                {
                                    variables.inspectedPivot.GetComponent<Rigidbody>().isKinematic = true;
                                }

                                StartCoroutine(pickupItem());
                            }
                        }


                    }
                }



            }
            else if (variables.onInspectedPivot == true && variables.pickUpClose == true)
            {

                StartCoroutine(dropItem());
                variables.mouseLock = true;
                variables.mouseVisible = false;
                variables.screenLock = false;
                variables.MovementLock = false;


                if (variables.inspectedPivot.GetComponent<Rigidbody>() != null)
                {
                    variables.inspectedPivot.GetComponent<Rigidbody>().isKinematic = false;

                }

                variables.onInspectedPivot = false;
            }



            if (variables.pickUpClose == true)
            {
                variables.AddButton.SetActive(false);
                variables.mouseLock = true;
                variables.mouseVisible = false;
                variables.screenLock = false;
                variables.MovementLock = false;
            }

            if (variables.onInspectedPivot)
            {
                if (variables.inspectedPivot.transform.position == variables.playerSocet.position)
                {
                    variables.playerSocet.position = variables.inspectedPivot.transform.position;
                }
                else
                {
                    variables.inspectedPivot.transform.position = Vector3.Lerp(variables.inspectedPivot.transform.position, variables.playerSocet.position, 0.2f);
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
            else if (variables.inspectedPivot != null)
            {
                Debug.Log(variables.inspectedPivot.name);

                variables.inspectedPivot.transform.SetParent(null);

                if (Physics.Raycast(myRay, out myRayCastHit, 20f))
                {

                    if (myRayCastHit.collider.gameObject.layer == 11)
                    {
                        if (Input.GetMouseButtonDown(0))
                        {
                            point = false;
                            variables.inspectedPivot.transform.position = myRayCastHit.point;
                            variables.inspectedPivot = null;
                        }
                        if (point)
                        {
                            variables.inspectedPivot.transform.position = myRayCastHit.point;
                            variables.inspectedPivot.transform.rotation = Quaternion.Euler(variables.originalRot.x, variables.originalRot.y, -90);
                        }


                    }
                }
            }

            variables.itemDestroyer.Activate(variables.thisSlott.ItemSlot.item, variables.thisSlott.SlotIndex);
            variables.itemDestroyer.Destroy();
            variables.pivot.SetActive(false);
        }

    }
    private IEnumerator pickupItem()
    {
        variables.inspectedPivot.transform.localScale = variables.orginalScale;
        // burada haraketi kapat
        yield return new WaitForSeconds(0.2f);
        variables.inspectedPivot.transform.SetParent(variables.playerSocet);
    }


    private IEnumerator dropItem()
    {


        yield return new WaitForSeconds(0.2f);
        // burada haraketi ac
    }
}

