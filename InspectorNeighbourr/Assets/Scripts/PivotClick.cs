using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotClick : MonoBehaviour
{
    private Variables variables;
    public List<GameObject> del = new List<GameObject>();
    private GameObject spawned;
    private bool point;
    private bool click = true;
    private void OnEnable()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();

    }

    public void Update()
    {
        Dell();
    }

    public void Del()
    {
        if (!variables.onInspected)
        {
            variables.delOpen = true;
            point = true;
            click = true;
        }




    }

    private void Dell()
    {


        if (variables.delOpen)
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

                if (point)
                {
                    for (int i = 0; i < del.Count; i++)
                    {
                        if (variables.thisSlott.ItemSlot.item.name == del[i].name)
                        {
                            spawned = Instantiate(del[i], variables.playerSocet.transform.position, Quaternion.identity);

                            spawned.name = variables.thisSlott.ItemSlot.item.name;
                            variables.inspected = spawned.transform.gameObject;
                            variables.originalPos = spawned.transform.position;
                            variables.originalRot = spawned.transform.rotation;
                            variables.onInspected = true;
                            variables.orginalScale = spawned.transform.localScale;
                            variables.AddButton.SetActive(true);
                            point = false;
                        }
                    }

                }




                variables.inspected.transform.SetParent(variables.playerSocet);



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

                variables.AddButton.SetActive(false);
                variables.mouseLock = true;
                variables.mouseVisible = false;
                variables.screenLock = false;
                variables.MovementLock = false;
            }

            if (variables.onInspected)
            {


                if (Input.GetMouseButton(1))
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (Physics.Raycast(myRay, out myRayCastHit, Mathf.Infinity))
                        {
                            if (myRayCastHit.collider.gameObject.layer == 8)
                            {

                                Destroy(myRayCastHit.collider.gameObject);
                            }
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

                variables.playerSocet.transform.rotation = variables.rotationY * variables.playerSocet.transform.rotation;

            }
            else if (variables.inspected != null)
            {
                variables.inspected.transform.SetParent(null);
                if (Physics.Raycast(myRay, out myRayCastHit, 20f))
                {
                    if (myRayCastHit.collider.gameObject.layer == 11)
                    {
                        if (Input.GetMouseButtonDown(0))
                        {
                            click = false;
                            variables.inspected.transform.position = myRayCastHit.point;
                            variables.inspected.GetComponent<Collider>().enabled = true;
                            variables.inspected = null;
                            variables.delOpen = false;
                        }
                        if (click)
                        {
                            variables.inspected.transform.position = myRayCastHit.point;
                            variables.inspected.transform.rotation = Quaternion.Euler(variables.originalRot.x, variables.originalRot.y, -90);


                        }


                    }
                }
                if (variables.inspected)
                {
                    variables.inspected.GetComponent<Collider>().enabled = false;

                }

            }

            variables.itemDestroyer.Destroy();
            variables.pivot.SetActive(false);
        }

    }


    IEnumerator pickupItem()
    {
        variables.inspected.transform.localScale = variables.orginalScale;
        // burada haraketi kapat
        yield return new WaitForSeconds(0.2f);
        
    }


    IEnumerator dropItem()
    {


        yield return new WaitForSeconds(0.2f);
        // burada haraketi ac
    }

}
