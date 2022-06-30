using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variables : MonoBehaviour
{
    [Header("Album")]
    
    public GameObject slot;


    [Header("SnapShotCamera")]
    [HideInInspector]
    public Image photoDisplayArea;
    [HideInInspector]
    public Texture2D screenCapture;

    
    public GameObject album;

   
    public List<Sprite> SsSprite = new List<Sprite>();

    [Header("Mouse")]

    public Vector3 orginalScale;
    public Vector3 originalPos;
    public Vector2 look;
    public Quaternion rotationY;
    public Transform playerSocet;

    
    public Camera playerCamera;

    
    public GameObject pin;
    public GameObject pin1;
    [HideInInspector]
    public GameObject inspected;

    
    [HideInInspector]
    public GameObject player;
    [HideInInspector]
    public GameObject pinClone;
    [HideInInspector]
    public bool onInspected = false;
    [HideInInspector]
    public float lastFrameMousePosX;
    [HideInInspector]
    public float lastFrameMousePosY;

    public float sensitivity;

    



    [Header("CameraZoom")]

    public int zoom = 20;
    public int normal = 60;
    public float smooth = 5;
    [HideInInspector]
    public bool isZoomed = false;


    [Header("MouseLook")]

    public Transform playerBody;
    

    public float mouseSensivity = 100f;
    [HideInInspector]
    public float xRotation = 0f;
    public bool mouseLock = false; 
    public bool mouseVisible = true;
    public bool screenLock = true;

    [Header("PlayerMove")]

    public CharacterController controller;

    public bool MovementLock = false;
    public float PlayerSpeed;

}
