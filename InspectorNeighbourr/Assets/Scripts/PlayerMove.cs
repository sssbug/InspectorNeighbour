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
                animator.SetBool("isBack", false);
                animator.SetBool("isIdle", false);
                animator.SetBool("isRight", false);
                animator.SetBool("isLeft", true);
                animator.SetBool("isWalk", false);

                Vector3 move = transform.right * x + transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isLeft", false);
                animator.SetBool("isBack", false);
                animator.SetBool("isWalk", false);
                animator.SetBool("isRight", true);
                Vector3 move = transform.right * x + transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isWalk", false);
                animator.SetBool("isRight", false);
                animator.SetBool("isLeft", false);
                animator.SetBool("isBack", true);
                animator.SetBool("isLeft", true);
                Vector3 move = transform.right * x + transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isWalk", false);
                animator.SetBool("isLeft", false);
                animator.SetBool("isBack", true);
                animator.SetBool("isRight", true);
                Vector3 move = transform.right * x + transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("isBack", false);
                animator.SetBool("isIdle", false);
                animator.SetBool("isRight", false);
                animator.SetBool("isLeft", false);
                animator.SetBool("isWalk", true);

                Vector3 move =  transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.S))
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isWalk", false);
                animator.SetBool("isRight", false);
                animator.SetBool("isLeft", false);
                animator.SetBool("isBack", true);
                Vector3 move = transform.forward * z;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.A))
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isWalk", false);
                animator.SetBool("isBack", false);
                animator.SetBool("isRight", false);
                animator.SetBool("isLeft", true);
                Vector3 move = transform.right * x;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isLeft", false);
                animator.SetBool("isBack", false);
                animator.SetBool("isWalk", false);
                animator.SetBool("isRight", true);
                Vector3 move = transform.right * x;
                variables.controller.Move(move * variables.PlayerSpeed * Time.deltaTime);
            }
            else
            {
                animator.SetBool("isWalk", false);
                animator.SetBool("isBack", false);
                animator.SetBool("isLeft", false);
                animator.SetBool("isRight", false);
                animator.SetBool("isIdle", true);
                
                return;
                
            }

            
        }
        
    }
}
