using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabs : MonoBehaviour
{

    public bool v = false;
    public bool c = false;
    public bool b = false;

    public GameObject venu;
    public GameObject chari;
    public GameObject blast;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnit();
    }

    public void spawnit()
    {


        ////////////////////////////////////////////////
        //////// RIGHT CLIKC TO ISTANTIATE ////////////
        /////////////////////////////////////////////////
        ///
        Vector2 mouse =  Camera.main.ScreenToWorldPoint( Input.mousePosition );

        if (gameObject.GetComponent<DropdownMenu>().blastoise == true && Input.GetMouseButtonDown(1)) //this checks if the venusaur boolean from the dropdownmenu script is set to true, and if it is then the code will run in order to show the correct sprite.
        {
            GameObject Bl = Instantiate(blast, mouse, Quaternion.identity);
            Destroy(Bl, 5);


        }
    }
    }
