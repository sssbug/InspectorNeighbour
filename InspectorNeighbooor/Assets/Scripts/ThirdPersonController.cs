using UnityEngine;


public class ThirdPersonController : MonoBehaviour
{
    private Variables variables;
    private const float _threshold = 0.01f;
    private void Awake()
    {
        variables = GameObject.Find("VariablesController").GetComponent<Variables>();



        // get a reference to our main camera
        if (variables._mainCamera == null)
        {
            variables._mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        }
    }

    private void Start()
    {


        //_hasAnimator = TryGetComponent(out _animator);
        variables._controller = GetComponent<CharacterController>();


        

        // reset our timeouts on start
        variables._jumpTimeoutDelta = variables.JumpTimeout;
        variables._fallTimeoutDelta = variables.FallTimeout;
    }

    private void Update()
    {
        //_hasAnimator = TryGetComponent(out _animator);

        JumpAndGravity();
        GroundedCheck();
        Move();
    }

    private void LateUpdate()
    {
        CameraRotation();
    }

    

    private void GroundedCheck()
    {
        // set sphere position, with offset
        Vector3 spherePosition = new Vector3(transform.position.x, transform.position.y - variables.GroundedOffset, transform.position.z);
        variables.Grounded = Physics.CheckSphere(spherePosition, variables.GroundedRadius, variables.GroundLayers, QueryTriggerInteraction.Ignore);

        // update animator if using character
        //if (_hasAnimator)
        //{
        //	_animator.SetBool(_animIDGrounded, Grounded);
        //}
    }

    private void CameraRotation()
    {
        // if there is an input and camera position is not fixed


        if (Input.GetKey(KeyCode.E))
        {
            variables.LockCameraPosition = true;
        }

        if (variables.look.sqrMagnitude >= _threshold && !variables.LockCameraPosition)
        {
            variables._cinemachineTargetYaw += variables.look.x * Time.deltaTime / 5;
            variables._cinemachineTargetPitch += variables.look.y * Time.deltaTime / 5;
        }

        // clamp our rotations so our values are limited 360 degrees
        variables._cinemachineTargetYaw = ClampAngle(variables._cinemachineTargetYaw, float.MinValue, float.MaxValue);
        variables._cinemachineTargetPitch = ClampAngle(variables._cinemachineTargetPitch, variables.BottomClamp, variables.TopClamp);

        // Cinemachine will follow this target
        variables.CinemachineCameraTarget.transform.rotation = Quaternion.Euler(variables._cinemachineTargetPitch + variables.CameraAngleOverride, variables._cinemachineTargetYaw, 0.0f);
    }

    private void Move()
    {
        // set target speed based on move speed, sprint speed and if sprint is pressed
        float targetSpeed = variables.MoveSpeed;

        // a simplistic acceleration and deceleration designed to be easy to remove, replace, or iterate upon

        // note: Vector2's == operator uses approximation so is not floating point error prone, and is cheaper than magnitude
        // if there is no input, set the target speed to 0
        if (variables.move == Vector2.zero) targetSpeed = 0.0f;

        // a reference to the players current horizontal velocity
        float currentHorizontalSpeed = new Vector3(variables._controller.velocity.x, 0.0f, variables._controller.velocity.z).magnitude;

        float speedOffset = 0.1f;
        float inputMagnitude = variables.analogMovement ? variables.move.magnitude : 1f;

        // accelerate or decelerate to target speed
        if (currentHorizontalSpeed < targetSpeed - speedOffset || currentHorizontalSpeed > targetSpeed + speedOffset)
        {
            // creates curved result rather than a linear one giving a more organic speed change
            // note T in Lerp is clamped, so we don't need to clamp our speed
            variables._speed = Mathf.Lerp(currentHorizontalSpeed, targetSpeed * inputMagnitude, Time.deltaTime * variables.SpeedChangeRate);

            // round speed to 3 decimal places
            variables._speed = Mathf.Round(variables._speed * 1000f) / 1000f;
        }
        else
        {
            variables._speed = targetSpeed;
        }
        variables._animationBlend = Mathf.Lerp(variables._animationBlend, targetSpeed, Time.deltaTime * variables.SpeedChangeRate);

        // normalise input direction
        Vector3 inputDirection = new Vector3(variables.move.x, 0.0f, variables.move.y).normalized;

        // note: Vector2's != operator uses approximation so is not floating point error prone, and is cheaper than magnitude
        // if there is a move input rotate player when the player is moving
        if (variables.move != Vector2.zero)
        {
            variables._targetRotation = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg + variables._mainCamera.transform.eulerAngles.y;
            float rotation = Mathf.SmoothDampAngle(transform.eulerAngles.y, variables._targetRotation, ref variables._rotationVelocity, variables.RotationSmoothTime);

            // rotate to face input direction relative to camera position
            transform.rotation = Quaternion.Euler(0.0f, rotation, 0.0f);
        }


        Vector3 targetDirection = Quaternion.Euler(0.0f, variables._targetRotation, 0.0f) * Vector3.forward;

        // move the player
        variables._controller.Move(targetDirection.normalized * (variables._speed * Time.deltaTime) + new Vector3(0.0f, variables._verticalVelocity, 0.0f) * Time.deltaTime);

        // update animator if using character
        //if (_hasAnimator)
        //{
        //	_animator.SetFloat(_animIDSpeed, _animationBlend);
        //	_animator.SetFloat(_animIDMotionSpeed, inputMagnitude);
        //}
    }

    private void JumpAndGravity()
    {
        if (variables.Grounded)
        {
            // reset the fall timeout timer
            variables._fallTimeoutDelta = variables.FallTimeout;

            // update animator if using character
            //if (_hasAnimator)
            //{
            //	_animator.SetBool(_animIDJump, false);
            //	_animator.SetBool(_animIDFreeFall, false);
            //}

            // stop our velocity dropping infinitely when grounded
            if (variables._verticalVelocity < 0.0f)
            {
                variables._verticalVelocity = -2f;
            }

            // Jump
            if (variables.jump && variables._jumpTimeoutDelta <= 0.0f)
            {
                // the square root of H * -2 * G = how much velocity needed to reach desired height
                variables._verticalVelocity = Mathf.Sqrt(variables.JumpHeight * -2f * variables.Gravity);

                // update animator if using character
                //if (_hasAnimator)
                //{
                //	_animator.SetBool(_animIDJump, true);
                //}
            }

            // jump timeout
            if (variables._jumpTimeoutDelta >= 0.0f)
            {
                variables._jumpTimeoutDelta -= Time.deltaTime;
            }
        }
        else
        {
            // reset the jump timeout timer
            variables._jumpTimeoutDelta = variables.JumpTimeout;

            // fall timeout
            if (variables._fallTimeoutDelta >= 0.0f)
            {
                variables._fallTimeoutDelta -= Time.deltaTime;
            }
            else
            {
                // update animator if using character
                //if (_hasAnimator)
                //{
                //	_animator.SetBool(_animIDFreeFall, true);
                //}
            }

            // if we are not grounded, do not jump
            variables.jump = false;
        }

        // apply gravity over time if under terminal (multiply by delta time twice to linearly speed up over time)
        if (variables._verticalVelocity < variables._terminalVelocity)
        {
            variables._verticalVelocity += variables.Gravity * Time.deltaTime;
        }
    }

    private static float ClampAngle(float lfAngle, float lfMin, float lfMax)
    {
        if (lfAngle < -360f) lfAngle += 360f;
        if (lfAngle > 360f) lfAngle -= 360f;
        return Mathf.Clamp(lfAngle, lfMin, lfMax);
    }

    //private void OnDrawGizmosSelected()
    //{
    //    Color transparentGreen = new Color(0.0f, 1.0f, 0.0f, 0.35f);
    //    Color transparentRed = new Color(1.0f, 0.0f, 0.0f, 0.35f);

    //    if (variables.Grounded) Gizmos.color = transparentGreen;
    //    else Gizmos.color = transparentRed;

    //    // when selected, draw a gizmo in the position of, and matching radius of, the grounded collider
    //    Gizmos.DrawSphere(new Vector3(transform.position.x, transform.position.y - variables.GroundedOffset, transform.position.z), variables.GroundedRadius);
    //}
}
