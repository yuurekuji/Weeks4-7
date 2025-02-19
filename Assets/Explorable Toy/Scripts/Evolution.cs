using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evolution : MonoBehaviour
{
    public Slider lv;
    public SpriteRenderer sr;
    public SpriteRenderer Blastoise;
    public SpriteRenderer Venusaur;
    public SpriteRenderer Charizard;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<SizeChange>().Size == 100)
        {
            sr.enabled = false;
            if (gameObject.GetComponent<DropdownMenu>().venusaur == true)
            {
                Venusaur.enabled = true;
                Charizard.enabled = false;
                Blastoise.enabled = false;
            }
            else if(gameObject.GetComponent<DropdownMenu>().blastoise == true)
            {
                Blastoise.enabled = true;
                Charizard.enabled = false;
                Venusaur.enabled = false;
            }
            else if(gameObject.GetComponent<DropdownMenu>().charizard == true)
            {
                Charizard.enabled = true;
                Blastoise.enabled = false;
                Venusaur.enabled = false;
            }

        }
        else
        {
            sr.enabled = true;
            Blastoise.enabled = false;
            Venusaur.enabled = false;
            Charizard.enabled = false;

        }
    }
}
