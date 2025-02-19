using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeChange : MonoBehaviour
{
    public float Size;
    public Slider Lv;

    // Start is called before the first frame update
    void Start()
    {
        //Size = gameObject.GetComponent<Text>().level;
    }

    // Update is called once per frame
    void Update()
    {

        Size = Lv.value; // this is to set the size variable to be a dynamic variable that is changed from the slider.

        Vector3 scale = transform.localScale;

        scale.y = Size*0.02f; // sets the scale.x to be able to be changed by the slider.
        scale.x = Size*0.02f; // sets the scale.y to be able to be changed by the slider.
        transform.localScale = scale;

    }
}
