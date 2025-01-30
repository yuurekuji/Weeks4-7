using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClockTurn : MonoBehaviour
{
    // Start is called before the first frame update

    public float SpinSpeed = 1;
    public AudioSource audi;

    public float time;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        time += 1* Time.deltaTime;

        Vector3 spin = transform.eulerAngles;

        spin.z -= SpinSpeed * Time.deltaTime;

        transform.eulerAngles = spin;

        if (time > 3.65)
        {
            audi.Play();
            time = 0;
        }

    }
    

}
