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
            audi.Play();
            venusaur = true;
            charizard = false;
            blastoise = false;
            
        }
        else if (dropdown.value == 2)// this is a conditional statement checking the value variable of the dropdown. if it is 2 then play the charmander sound

        {
            audi2.Play();
            charizard = true;
            venusaur = false;
            blastoise = false;
        }
        else if (dropdown.value == 3)// this is a conditional statement checking the value variable of the dropdown. if it is 3 then play the squirtle sound

        {
            audi3.Play();
            blastoise = true;
            charizard = false;
            venusaur = false;
        }

    }
}
