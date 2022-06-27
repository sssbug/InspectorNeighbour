using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Album : MonoBehaviour
{
    public GameObject slot;
    private SnapshotCamera snapShot;

    private void Start()
    {
        snapShot = GameObject.Find("CameraManager").GetComponent<SnapshotCamera>();
    }

    private void OnEnable()
    {
        snapShot = GameObject.Find("CameraManager").GetComponent<SnapshotCamera>();
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject game = Instantiate(slot);
            game.transform.parent = this.transform.GetChild(0).transform;
            Image slote = game.GetComponent<Image>();
             
            foreach (var item in snapShot.SsSprite)
            {
                Debug.Log("ne");
                slote.sprite = item;
            }
        }
        
    }
}
 