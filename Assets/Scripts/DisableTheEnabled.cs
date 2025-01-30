using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableTheEnabled : MonoBehaviour
{

    public SpriteRenderer sr;
    public DisableTheEnabled Script;
    public GameObject go;
    public AudioSource Audi;
    public AudioClip clip;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sr.enabled = false;
            //Script.enabled = false;
            go.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = true;
            //Script.enabled = true;
            go.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (Audi.isPlaying == false)
            {
                Audi.Play();
                //Audi.PlayOneShot(clip);
            }


        }
    }
}
