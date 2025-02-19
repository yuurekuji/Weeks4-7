using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    public TextMeshProUGUI Level;
    float level = 1;
    public Slider Lv;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        level = Lv.value; // this chnged the value of the float to the value of the slider, this ensures that the level displayed on the screen will a variable in the slider.
        Level.text = level.ToString(); // this forces the float to be a string which can be shown inside the game and textmesh
        print(Lv.value); // this is to debug to check if the slider is actually working.
    }
}
