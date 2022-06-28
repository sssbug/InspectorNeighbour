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
        if (Input.GetKey(KeyCode.E))
        {
            if (Physics.Raycast(myRay, out myRayCastHit, Mathf.Infinity))
            {
                if (myRayCastHit.collider.gameObject.layer == 6 && !variables.onInspected)
                {

                    if (Input.GetMouseButtonDown(0))
                    {
                        variables.inspected = myRayCastHit.transform.gameObject;
                        variables.originalPos = myRayCastHit.transform.position;
                        variables.onInspected = true;
                        variables.orginalScale = myRayCastHit.transform.localScale;

                        myRayCastHit.rigidbody.isKinematic = true;
                        StartCoroutine(pickupItem());
                    }

                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) && variables.onInspected == true)
        {

            StartCoroutine(dropItem());

            variables.inspected.GetComponent<Rigidbody>().isKinematic = false;
            variables.onInspected = false;
        }
        //else
        //{

        //    if (Physics.Raycast(myRay, out myRayCastHit, 3f))
        //    {
        //        if (myRayCastHit.collider.gameObject.layer == 7)
        //        {
        //            variables.anim = myRayCastHit.collider.gameObject.transform.parent.gameObject.GetComponent<Animator>();

        //            if (myRayCastHit.collider.name == "Cube.010")
        //            {
        //                if (Input.GetKey(KeyCode.R))
        //                {
        //                    variables.anim.SetFloat("speedL", 1);
        //                }
        //            }
        //            else if (myRayCastHit.collider.name == "Cube.011")
        //            {
        //                if (Input.GetKey(KeyCode.R))
        //                {
        //                    variables.anim.SetFloat("speedR", 1);
        //                }
        //            }
        //            else
        //            {
        //                if (Input.GetKey(KeyCode.R))
        //                {
        //                    variables.anim.SetFloat("speed", 1);
        //                }
        //            }
        //        }
        //    }
        //}

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

        }

        if (Physics.Raycast(myRay, out myRayCastHit, Mathf.Infinity))
        {

            if (myRayCastHit.collider.gameObject.layer == 10)
            {
                if (Input.GetKeyDown(KeyCode.X))
                {

                    variables.games = Instantiate(variables.gamePrefab, myRayCastHit.point, Quaternion.identity);
                    variables.games.transform.localRotation = Quaternion.Euler(0, -90, 0);

                }
                else if (Input.GetKey(KeyCode.X))
                {

                    variables.games.transform.position = myRayCastHit.point;

                }
                else if (Input.GetKeyUp(KeyCode.X))
                {
                    variables.album.transform.position = myRayCastHit.point + new Vector3(1, 0, -0.2f);
                    variables.album.SetActive(true);
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.None;

                    variables.cursorInputForLook = false;


                    variables.LockCameraPosition = true;

                }
                else if (Input.GetKeyDown(KeyCode.V))
                {

                    variables.game = Instantiate(variables.gamePre, myRayCastHit.point, Quaternion.identity);

                }
                else if (Input.GetKey(KeyCode.V))
                {
                    variables.games.transform.position = myRayCastHit.point;

                }
                else if (Input.GetKeyUp(KeyCode.V))
                {
                    Destroy(variables.games);
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
