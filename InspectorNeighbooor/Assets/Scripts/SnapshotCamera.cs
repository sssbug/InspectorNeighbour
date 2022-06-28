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
        
        Sprite photoSprite = Sprite.Create(variables.screenCapture, new Rect(0.0f,0.0f, variables.screenCapture.width, variables.screenCapture.height), new Vector2(0.5f,0.5f),100.0f);
        variables.SsSprite.Add(photoSprite);

        

        GameObject game = Instantiate(variables.slot);
        game.transform.position = variables.album.transform.GetChild(0).transform.position;
        game.transform.rotation = variables.album.transform.GetChild(0).transform.rotation;
        game.transform.parent = variables.album.transform.GetChild(0).transform;
        Image slote = game.GetComponent<Image>();
        slote.sprite = variables.SsSprite[variables.SsSprite.Count - 1];






        /*
        GameObject spawn = new GameObject();
        spawn = game;
        photoDisplayArea = spawn.transform.GetChild(0).transform.GetChild(0).GetComponent<Image>();

        photoDisplayArea.sprite = photoSprite;

        SsSpawn.Add(spawn);
        */
    }
    //    Camera snapCam;
    //    int resWith = 256;
    //    int resHeight = 256;

    //    void Awake()
    //    {
    //        snapCam = GetComponent<Camera>();
    //        if (snapCam.targetTexture == null)
    //        {
    //            snapCam.targetTexture = new RenderTexture(resWith, resHeight, 24);
    //        }
    //        else
    //        {
    //            resWith = snapCam.targetTexture.width;
    //            resHeight = snapCam.targetTexture.height;

    //        }
    //        snapCam.gameObject.SetActive(false);
    //    }



    //    public void CallTakeSnapShot()
    //    {
    //        snapCam.gameObject.SetActive(true);

    //    }
    //    private void LateUpdate()
    //    {
    //        if (snapCam.gameObject.activeInHierarchy)
    //        {
    //            Texture2D snapshot = new Texture2D(resWith, resHeight, TextureFormat.RGB24, false);
    //            snapCam.Render();
    //            RenderTexture.active = snapCam.targetTexture;
    //            snapshot.ReadPixels(new Rect(0, 0, resWith, resHeight), 0, 0);
    //            byte[] bytes = snapshot.EncodeToPNG();
    //            string fileName = SnapShotName();
    //            System.IO.File.WriteAllBytes(fileName, bytes);
    //            snapCam.gameObject.SetActive(false);
    //        }
    //    }

    //    string SnapShotName()
    //    {
    //        return string.Format("{0}/Snapshots/snap_{1}x{2}_{3}.png", Application.dataPath, resWith, resHeight, System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
    //    }
}
