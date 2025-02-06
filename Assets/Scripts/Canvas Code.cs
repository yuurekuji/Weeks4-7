using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasCode : MonoBehaviour
{

    public GameObject Go;
    public bool ismousedown = false;

    public Sprite sp;

    public AudioSource audi;

    public SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 pos = sprite.transform.position;
        Vector2 Screens = Camera.main.ScreenToWorldPoint(mouse);

        if (Input.GetMouseButtonDown(0) && sprite.bounds.Contains(Screens))
        {
            audi.Play();
            ismousedown = !ismousedown;
        }


        if (ismousedown == true)
        {
         
            Go.SetActive(true);
        }
        else
        {
            audi.Stop();
            Go.SetActive(false);
        }

        
    }
}
