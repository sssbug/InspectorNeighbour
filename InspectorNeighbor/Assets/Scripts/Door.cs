using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    MouseController mouse;
    Animator anime;
    [HideInInspector]
    public Animator animUi;
    public int isBe = 0;
    AnimationController animationControl;
    
    bool isDo;
    List<Animator> animeList = new List<Animator>();
    private void Start()
    {
        mouse = GameObject.Find("MouseController").GetComponent<MouseController>();
        anime = GetComponent<Animator>();
        //animationControl = GameObject.Find("image").GetComponent<AnimationController>();

        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    animUi = gameObject.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(i).gameObject.GetComponent<Animator>();
        //    animeList.Add(animUi);
        //}
        
    }

    //private void Update()
    //{

    //    if (isDo == true)
    //    {
    //        if (animationControl.openUi == true)
    //        {
    //            for (int i = 0; i < animeList.Count; i++)
    //            {
    //                animeList[i].SetFloat("speed", 1);
    //            }
    //        }
    //    }
    //    else
    //    {
    //        if (isBe == 1)
    //        {
    //            animationControl.openUi = true;
    //            for (int i = 0; i < animeList.Count; i++)
    //            {
    //                animeList[i].SetFloat("speed", -1);
    //            }
    //            isBe = 0;
    //        }
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 2)
        {
            isDo = true;
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 2)
        {
            isDo = false;
        }
    }

    void Open()
    {
        anime.SetFloat("speed", 0);
    }
}
