using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoPut : MonoBehaviour
{
    private Variables variables;


    private void OnEnable()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();

    }







    public void Click()
    {
        GameObject card = Instantiate(variables.card, variables.pinList[variables.pinList.Count - 1].transform.position + new Vector3(0.064f, -.2f, 0), Quaternion.identity);
        card.transform.rotation = Quaternion.Euler(0,0,-90);
        card.transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
        variables.SsSprite.Remove(gameObject.GetComponent<Image>().sprite);
        variables.cardList.Add(card);
        Destroy(gameObject);
        variables.mouseLock = true;
        variables.mouseVisible = false;
        variables.screenLock = false;
        variables.MovementLock = false;
        variables.album.SetActive(false);
    }

}