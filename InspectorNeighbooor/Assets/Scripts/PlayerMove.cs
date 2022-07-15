using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private Variables variables;
    private Animator animator;

    private void Start()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (!variables.MovementLock)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");


            

            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                Vector3 move = transform.right * x + transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                Vector3 move = transform.right * x + transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                Vector3 move = transform.right * x + transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                Vector3 move = transform.right * x + transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isWalk", true);


                Vector3 move =  transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.S))
            {

                Vector3 move = transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.A))
            {
                Vector3 move = transform.right * x;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Vector3 move = transform.right * x;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else
            {
                animator.SetBool("isIdle", true);
                animator.SetBool("isWalk", false);
                return;
                
            }

            
        }
        
    }
}
