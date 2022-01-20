using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    MouseController mouse;
    Animator anime;
    [HideInInspector]
    public Animator animUi;
    
    [HideInInspector]
    public bool openUi = true;
    Door door;

    private void Start()
    {
        mouse = GameObject.Find("MouseController").GetComponent<MouseController>();
        anime = GetComponent<Animator>();
        door = GameObject.Find("Door").GetComponent<Door>();
    }

    void OpenUI()
    {
        
        
        if (openUi == true)
        {
            anime.SetFloat("speed",0);
            openUi = false;
            
        }

        door.isBe = 1;
    }

    void CloseUI() {
        
        //Debug.Log(door.isBe);

        anime.SetFloat("speed", 0);
        openUi = true;


    }
}