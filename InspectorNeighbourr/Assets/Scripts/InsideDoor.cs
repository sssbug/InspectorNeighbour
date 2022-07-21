using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideDoor : MonoBehaviour
{
    Animator anime;
    private void Start()
    {
        
        anime = GetComponent<Animator>();
    }
    void Open()
    {
        anime.SetFloat("speed", 0);
    }
    void OpenR()
    {
        anime.SetFloat("speedR", 0);
    }
    void OpenL()
    {
        anime.SetFloat("speedL", 0);
    }
}
