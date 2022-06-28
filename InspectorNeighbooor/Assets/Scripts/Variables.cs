using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variables : MonoBehaviour
{
    [Header("Album")]

    public GameObject slot;


    [Header("SnapShotCamera")]

    public Image photoDisplayArea;
    public Texture2D screenCapture;

    public GameObject game;
    public GameObject album;

    public List<GameObject> SsSpawn = new List<GameObject>();
    public List<Sprite> SsSprite = new List<Sprite>();

    [Header("Mouse")]

    public Vector3 orginalScale;
    public Vector3 originalPos;
    public Vector2 look;
    public Quaternion rotationY;
    public Transform playerSocet;

    
    public Camera playerCamera;

    
    public GameObject gamePrefab;
    public GameObject gamePre;
    public GameObject inspected;

    [HideInInspector]
    public Animator anim;
    [HideInInspector]
    public GameObject player;
    [HideInInspector]
    public GameObject games;
    [HideInInspector]
    public bool onInspected = false;
    [HideInInspector]
    public float lastFrameMousePosX;
    [HideInInspector]
    public float lastFrameMousePosY;

    public float sensitivity;

    public bool cursorLocked = true;
    public bool cursorInputForLook = true;



    [Header("CameraZoom")]

    public int zoom = 20;
    public int normal = 60;
    public float smooth = 5;
    [HideInInspector]
    public bool isZoomed = false;

    [Header("ThirdPersonController")]

	
	[Tooltip("Move speed of the character in m/s")]
	public float MoveSpeed = 2.0f;
	[Tooltip("Sprint speed of the character in m/s")]
	public float SprintSpeed = 5.335f;
	[Tooltip("How fast the character turns to face movement direction")]
	[Range(0.0f, 0.3f)]
	public float RotationSmoothTime = 0.12f;
	[Tooltip("Acceleration and deceleration")]
	public float SpeedChangeRate = 10.0f;

	[Space(10)]
	[Tooltip("The height the player can jump")]
	public float JumpHeight = 1.2f;
	[Tooltip("The character uses its own gravity value. The engine default is -9.81f")]
	public float Gravity = -15.0f;

	[Space(10)]
	[Tooltip("Time required to pass before being able to jump again. Set to 0f to instantly jump again")]
	public float JumpTimeout = 0.50f;
	[Tooltip("Time required to pass before entering the fall state. Useful for walking down stairs")]
	public float FallTimeout = 0.15f;

	[Header("Player Grounded")]
	[Tooltip("If the character is grounded or not. Not part of the CharacterController built in grounded check")]
	public bool Grounded = true;
	[Tooltip("Useful for rough ground")]
	public float GroundedOffset = -0.14f;
	[Tooltip("The radius of the grounded check. Should match the radius of the CharacterController")]
	public float GroundedRadius = 0.28f;
	[Tooltip("What layers the character uses as ground")]
	public LayerMask GroundLayers;

	[Header("Cinemachine")]
	[Tooltip("The follow target set in the Cinemachine Virtual Camera that the camera will follow")]
	public GameObject CinemachineCameraTarget;
	[Tooltip("How far in degrees can you move the camera up")]
	public float TopClamp = 70.0f;
	[Tooltip("How far in degrees can you move the camera down")]
	public float BottomClamp = -30.0f;
	[Tooltip("Additional degress to override the camera. Useful for fine tuning camera position when locked")]
	public float CameraAngleOverride = 0.0f;
	[Tooltip("For locking the camera position on all axis")]
	public bool LockCameraPosition = false;
	[HideInInspector]
	// cinemachine
	public float _cinemachineTargetYaw;
	[HideInInspector]
	public float _cinemachineTargetPitch;

	// player
	[HideInInspector]
	public float _speed;
	[HideInInspector]
	public float _animationBlend;
	[HideInInspector]
	public float _targetRotation = 0.0f;
	[HideInInspector]
	public float _rotationVelocity;
	[HideInInspector]
	public float _verticalVelocity;
	[HideInInspector]
	public float _terminalVelocity = 53.0f;

	// timeout deltatime
	[HideInInspector]
	public float _jumpTimeoutDelta;
	[HideInInspector]
	public float _fallTimeoutDelta;

	// animation IDs
	[HideInInspector]
	public int _animIDSpeed;
	[HideInInspector]
	public int _animIDGrounded;
	[HideInInspector]
	public int _animIDJump;
	[HideInInspector]
	public int _animIDFreeFall;
	[HideInInspector]
	public int _animIDMotionSpeed;
	
	[HideInInspector]
	public CharacterController _controller;
	[HideInInspector]
	public GameObject _mainCamera;
	

	[Header("Staarter")]
	
	public Vector2 move;
	
	public bool jump;
	public bool sprint;

	
	public bool analogMovement;

	
}
