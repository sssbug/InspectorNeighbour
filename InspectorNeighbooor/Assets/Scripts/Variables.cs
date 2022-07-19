using Hel.Items.Inventories;
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
    public Quaternion originalRot;
    public Vector2 look;
    public Quaternion rotationY;
    public Transform playerSocet;

    
    public Camera playerCamera;
    public GameObject cameraBody;
    
    public GameObject pin;
    
    [HideInInspector]
    public GameObject inspected;
    public GameObject AddButton;
    
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
    public float normal;
    public float smooth = 5;
    [HideInInspector]
    public bool isZoomed = false;


    [Header("MouseLook")]

    public Transform playerBody;
    

    public float mouseSensivity = 100f;
    [HideInInspector]
    public float xRotation = 0f;
    public float yRotation = 0f;
    public bool mouseLock; 
    public bool mouseVisible;
    public bool screenLock;

    [Header("PlayerMove")]

    public CharacterController controller;

    public bool MovementLock = false;
    public float PlayerSpeed;


    [Header("PhotoPut")]

    public List<GameObject> pinList = new List<GameObject>();
    public List<GameObject> cardList = new List<GameObject>();
    public GameObject card;

    [Header("PickUp")]

    public bool pickUpOpen = false;
    public bool pickUpClose = true;

    [Header("InventoryUI")]

    public GameObject pivot;
    [HideInInspector]
    public InventorySlot thisSlott = null;
    public ItemDestroyer itemDestroyer = null;

    public bool hover;

}
