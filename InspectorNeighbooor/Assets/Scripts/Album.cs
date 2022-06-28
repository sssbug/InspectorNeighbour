using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Album : MonoBehaviour
{

    private Variables variables;

    private void OnEnable()
    {
         variables = GameObject.Find("VariablesController").GetComponent<Variables>();
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            GameObject game = Instantiate(variables.slot);
            game.transform.parent = this.transform.GetChild(0).transform;
            Image slote = game.GetComponent<Image>();
            slote.sprite = variables.SsSprite[variables.SsSprite.Count - 1];
            
        }
        
    }
}
 