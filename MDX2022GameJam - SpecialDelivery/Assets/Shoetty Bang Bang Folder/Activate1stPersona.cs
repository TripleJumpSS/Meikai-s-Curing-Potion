using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate1stPersona : MonoBehaviour
{
    public GameObject FIRSTPERSONA;
    public GameObject THIRDPERSONA;
    public GameObject Crosshairs;
    public bool ILLUSEMYPERSONA;
    public GameObject PLAYER2D;
    void Start()
    {
        ILLUSEMYPERSONA = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ILLUSEMYPERSONA == true)
        {FIRSTPERSONA.SetActive (true);
        THIRDPERSONA.SetActive (false);
        Crosshairs.SetActive (true);
        PLAYER2D.GetComponent<PlayerMovementAdvanced>().enabled = false;}
        else
        {FIRSTPERSONA.SetActive (false);
        THIRDPERSONA.SetActive (true);
        Crosshairs.SetActive (false);
        PLAYER2D.GetComponent<PlayerMovementAdvanced>().enabled = true;}

        if(Input.GetMouseButtonDown(1) && ILLUSEMYPERSONA == true)
        {ILLUSEMYPERSONA = false;}
        
        else if(Input.GetMouseButtonDown(1) && ILLUSEMYPERSONA == false)
        {ILLUSEMYPERSONA = true;}
    }
}
