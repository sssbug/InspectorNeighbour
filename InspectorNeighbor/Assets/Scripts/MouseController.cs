using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;


public class MouseController : MonoBehaviour
{

    Camera playerCamera;
    GameObject player;
    [HideInInspector]
    public Animator anim;
    AnimationController animationControl;





    public Transform playerSocet;

    Vector3 orginalScale;
    Vector3 originalPos;
    bool onInspected = false;
    GameObject inspected;


    ThirdPersonController thirdPerson;



    [SerializeField] private float sensitivity;

    private Quaternion rotationY;


    float lastFrameMousePosX;
    float lastFrameMousePosY;



    private void Start()
    {

        animationControl = GameObject.Find("image").GetComponent<AnimationController>();
        thirdPerson = GameObject.Find("PlayerArmature").GetComponent<ThirdPersonController>();
    }

    public void Update()
    {


        Mouse();
    }




    private void Mouse()
    {
        playerCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit myRayCastHit;
        if (Input.GetKey(KeyCode.E))
        {
            if (Physics.Raycast(myRay, out myRayCastHit, Mathf.Infinity))
            {
                if (myRayCastHit.collider.gameObject.layer == 6 && !onInspected)
                {

                    if (Input.GetMouseButtonDown(0))
                    {

                        inspected = myRayCastHit.transform.gameObject;
                        originalPos = myRayCastHit.transform.position;
                        onInspected = true;
                        orginalScale = myRayCastHit.transform.localScale;

                        myRayCastHit.rigidbody.isKinematic = true;
                        StartCoroutine(pickupItem());
                    }

                }



            }
        }
        else if (Input.GetKeyUp(KeyCode.E) && onInspected == true)
        {

            StartCoroutine(dropItem());

            inspected.GetComponent<Rigidbody>().isKinematic = false;
            onInspected = false;
        }
        else
        {

            if (Physics.Raycast(myRay, out myRayCastHit, 3f))
            {
                if (myRayCastHit.collider.gameObject.layer == 7)
                {
                    anim = myRayCastHit.collider.gameObject.transform.parent.gameObject.GetComponent<Animator>();

                    if (myRayCastHit.collider.name == "Cube.010")
                    {
                        if (Input.GetKey(KeyCode.R))
                        {
                            anim.SetFloat("speedL", 1);
                        }
                    }
                    else if (myRayCastHit.collider.name == "Cube.011")
                    {
                        if (Input.GetKey(KeyCode.R))
                        {
                            anim.SetFloat("speedR", 1);
                        }
                    }
                    else
                    {
                        if (Input.GetKey(KeyCode.R))
                        {
                            anim.SetFloat("speed", 1);
                        }
                    }
                }
            }
        }
        if (onInspected)
        {
            if (inspected.transform.position == playerSocet.position)
            {
                playerSocet.position = inspected.transform.position;

            }
            else
            {

                inspected.transform.position = Vector3.Lerp(inspected.transform.position, playerSocet.position, 0.2f);
            }
            if (Physics.Raycast(myRay, out myRayCastHit, Mathf.Infinity))
            {
                if (Input.GetMouseButton(1))
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (myRayCastHit.collider.gameObject.layer == 8)
                        {
                            Debug.Log("Kanit yakalandi");
                            Destroy(myRayCastHit.collider.gameObject);
                        }
                    }
                }
                else
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        lastFrameMousePosX = Input.mousePosition.x;
                        lastFrameMousePosY = Input.mousePosition.y;
                    }
                    if (Input.GetMouseButton(0))
                    {

                        float _inputDifferenceY = Input.mousePosition.x - lastFrameMousePosX;
                        float _inputDifferenceX = Input.mousePosition.y - lastFrameMousePosY;
                        rotationY = Quaternion.Euler(0f, -_inputDifferenceY * sensitivity * Time.deltaTime, _inputDifferenceX * sensitivity * Time.deltaTime);
                        lastFrameMousePosX = Input.mousePosition.x;
                        lastFrameMousePosY = Input.mousePosition.y;

                    }

                    if (Input.GetMouseButtonUp(0))
                    {

                        rotationY = Quaternion.Euler(0f, 0f, 0f);

                    }
                }
            }
            playerSocet.transform.rotation = rotationY * playerSocet.transform.rotation;

        }
        else if (inspected != null)
        {

            inspected.transform.SetParent(null);
            inspected.transform.position = Vector3.Lerp(inspected.transform.position, originalPos, 0.2f);

        }
    }
    IEnumerator pickupItem()
    {
        inspected.transform.localScale = orginalScale;
        thirdPerson.enabled = false;
        yield return new WaitForSeconds(0.2f);
        inspected.transform.SetParent(playerSocet);
    }


    IEnumerator dropItem()
    {

        
        yield return new WaitForSeconds(0.2f);
        thirdPerson.enabled = true;
    }
}

