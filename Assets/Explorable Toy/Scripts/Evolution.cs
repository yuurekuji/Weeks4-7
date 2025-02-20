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
        if (gameObject.GetComponent<SizeChange>().Size == 100) // this is a conditional to check if the size variable inside the SizeChange function is at 100 (meaning that the level will then be 100)
        {
            sr.enabled = false; // this disables the sprite renderer componnet of the orignal pokemon so that it does not show when the evolved form appears. this is only triggered when the level is 100,

            if (gameObject.GetComponent<DropdownMenu>().venusaur == true) //this checks if the venusaur boolean from the dropdownmenu script is set to true, and if it is then the code will run in order to show the correct sprite.
            {
                Venusaur.enabled = true;// this enables the correct sprite

                // we disable the rest just incase to be sure that there are not multiple different sprites showing up at a time.
                Charizard.enabled = false;
                Blastoise.enabled = false;
            }
            else if(gameObject.GetComponent<DropdownMenu>().blastoise == true) //this checks if the blastoise boolean from the dropdownmenu script is set to true, and if it is then the code will run in order to show the correct sprite.
            {
                Blastoise.enabled = true; // this enables the correct sprite

                // we disable the rest just incase to be sure that there are not multiple different sprites showing up at a time.
                Charizard.enabled = false;
                Venusaur.enabled = false;
            }
            else if(gameObject.GetComponent<DropdownMenu>().charizard == true)//this checks if the charizard boolean from the dropdownmenu script is set to true, and if it is then the code will run in order to show the correct sprite.
            {
                Charizard.enabled = true;// this enables the correct sprite

                // we disable the rest just incase to be sure that there are not multiple different sprites showing up at a time.
                Blastoise.enabled = false;
                Venusaur.enabled = false;
            }

        }
        else
        {
            sr.enabled = true; // this enables the sprite renderer component when the level is less than 100


            // we disable the rest just incase to be sure that there are not multiple different sprites showing up at a time.
            Blastoise.enabled = false;
            Venusaur.enabled = false;
            Charizard.enabled = false;

        }
    }
}
