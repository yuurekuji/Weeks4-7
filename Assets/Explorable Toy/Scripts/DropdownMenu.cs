using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownMenu : MonoBehaviour
{

    public TMP_Dropdown dropdown;
    public SpriteRenderer spriteRenderer;
    public AudioSource audi;
    public AudioSource audi2;
    public AudioSource audi3;
    public bool charizard = false;
    public bool blastoise = false;
    public bool venusaur = false;

    // Start is called before the first frame update

    private void Start()
    {
        spriteRenderer.sprite = dropdown.options[0].image; // this is to ensure that when the game starts, what wil be displayed is the pokeball.
    }
    public void onValueChanged(int index)
    {
        // this is to extrapolate which index value we have, (reference to the value on the drop down menu) and to spawn the pokemon I wish to see for the specific options.
        Debug.Log(dropdown.options[index].text); // this is to debug to check if the option for the menu is in fact working before getting to the spawning.
        spriteRenderer.sprite = dropdown.options[index].image;

    }

    public void Update()
    {
        if (dropdown.value == 1) // this is a conditional statement checking the value variable of the dropdown. if it is 1 thenplay the bulbasaur sound
        {
            audi.Play(); // this plays the selected audio when the value is a certain value.

            // we set Venusuar to true and turn everythung else to false for an added layer of protection. This ensures that only one boolean is on at a time when sometimes there may be issues where multiple are displaying.
            venusaur = true;
            charizard = false;
            blastoise = false;
            
        }
        else if (dropdown.value == 2)// this is a conditional statement checking the value variable of the dropdown. if it is 2 then play the charmander sound

        {
            audi2.Play();// this plays the selected audio when the value is a certain value.

            // we set charizard to true and turn everythung else to false for an added layer of protection. This ensures that only one boolean is on at a time when sometimes there may be issues where multiple are displaying.
            charizard = true; 
            venusaur = false;
            blastoise = false;
        }
        else if (dropdown.value == 3)// this is a conditional statement checking the value variable of the dropdown. if it is 3 then play the squirtle sound

        {
            audi3.Play();// this plays the selected audio when the value is a certain value.

            // we set Blastoise to true and turn everythung else to false for an added layer of protection. This ensures that only one boolean is on at a time when sometimes there may be issues where multiple are displaying.
            blastoise = true;
            charizard = false;
            venusaur = false;
        }

    }
}
