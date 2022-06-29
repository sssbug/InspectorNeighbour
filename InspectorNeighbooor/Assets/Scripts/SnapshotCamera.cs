using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SnapshotCamera : MonoBehaviour
{
    private Variables variables;


    private void Start()
    {
        
        variables = GameObject.Find("VariablesController").GetComponent<Variables>();

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(CapturePhoto());
        }
        
    }


    IEnumerator CapturePhoto()
    {
        yield return new WaitForEndOfFrame();

        Rect regionToRead = new Rect(0,0,Screen.width,Screen.height);
        variables.screenCapture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        variables.screenCapture.ReadPixels(regionToRead,0,0,false);

        variables.screenCapture.Apply();
        
        ShowPhoto();
    }

    void ShowPhoto()
    {

        Sprite photoSprite = Sprite.Create(variables.screenCapture, new Rect(0.0f, 0.0f, variables.screenCapture.width, variables.screenCapture.height), new Vector2(0.5f, 0.5f), 100.0f);
        variables.SsSprite.Add(photoSprite);



        GameObject game = Instantiate(variables.slot);
        game.transform.position = variables.album.transform.GetChild(0).transform.position;
        game.transform.rotation = variables.album.transform.GetChild(0).transform.rotation;
        game.transform.parent = variables.album.transform.GetChild(0).transform;
        Image slote = game.GetComponent<Image>();
        slote.sprite = variables.SsSprite[variables.SsSprite.Count - 1];


    }
}
