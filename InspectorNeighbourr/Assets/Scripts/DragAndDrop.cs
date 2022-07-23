using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragAndDrop : MonoBehaviour
{

    //Vector3 offset;
    private Variables variables;
    //Vector3 point;

    private void Start()
    {
        variables = GameObject.Find("VariablesController").GetComponent<Variables>();
    }

    //private void OnMouseDown()
    //{
    //    transform.GetComponent<Rigidbody>().isKinematic = true;
    //    transform.GetComponent<Rigidbody>().useGravity = false;
    //    offset = transform.position - MouseWorldPosition();
    //    transform.GetComponent<Collider>().enabled = false;
    //    point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //}
    //private void OnMouseDrag()
    //{

    //    //point.x = gameObject.transform.position.x;
    //    //point.y = gameObject.transform.position.y;
    //    //point.z = gameObject.transform.position.z;
    //    gameObject.transform.position = new Vector3();
    //    //transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 0.3f,-0.3f);
    //}


    //private void OnMouseUp()
    //{


    //    transform.GetComponent<Rigidbody>().useGravity = true;
    //    transform.GetComponent<Rigidbody>().isKinematic = false;
    //    transform.GetComponent<Collider>().enabled = true;
    //}

    //Vector3 MouseWorldPosition()
    //{
    //    var mouseScreenPos = Input.mousePosition;
    //    mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
    //    return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    //}


    [SerializeField]
    private InputAction mouseClick;
    [SerializeField]
    private float mouseDragPhysicsSpeed = 10;
    [SerializeField]
    private float mouseDragSpeed = .1f;
    private WaitForFixedUpdate waitForFixedUpdate = new WaitForFixedUpdate();
    private Vector3 velocity = Vector3.zero;
   

    private void OnEnable()
    {
        mouseClick.Enable();
        mouseClick.performed += MousePressed;
    }

    private void OnDisable()
    {
        mouseClick.performed -= MousePressed;
        mouseClick.Disable();
    }

    private void MousePressed(InputAction.CallbackContext context)
    {
        Ray ray = variables.playerCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.layer == 12)
            {
               
                
                StartCoroutine(DragUpdate(hit.collider.gameObject));
            }

        }
       
    }
    private IEnumerator DragUpdate(GameObject clickObject)
    {
        float initialDistance = Vector3.Distance(clickObject.transform.position, variables.playerCamera.transform.position);
        clickObject.TryGetComponent<Rigidbody>(out var rb);
        while (mouseClick.ReadValue<float>() != 0)
        {
            Ray ray = variables.playerCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (rb != null)
            {
                Vector3 direction = ray.GetPoint(initialDistance) - clickObject.transform.position ;
                rb.velocity = direction * mouseDragPhysicsSpeed;
                yield return waitForFixedUpdate;
            }
            else
            {
                clickObject.transform.position = Vector3.SmoothDamp(clickObject.transform.position,ray.GetPoint(initialDistance), ref velocity, mouseDragSpeed);
                yield return null;
            }
            
        }
    }
}
