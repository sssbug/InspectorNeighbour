using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvents : MonoBehaviour
{
    private Variables variables;


    private void Start()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();

    }

    public void Close()
    {
        if (variables.cardList.Count != variables.pinList.Count)
        {
            Destroy(variables.pinList[variables.pinList.Count - 1]);
            variables.mouseLock = true;
            variables.mouseVisible = false;
            variables.screenLock = false;
            variables.MovementLock = false;
            variables.album.SetActive(false);
        }
        else
        {
            variables.mouseLock = true;
            variables.mouseVisible = false;
            variables.screenLock = false;
            variables.MovementLock = false;
            variables.album.SetActive(false);
        }

    }
}
