using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float f = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            pos.x -= f * Time.deltaTime;
        }

        transform.position = pos;

    }
}
