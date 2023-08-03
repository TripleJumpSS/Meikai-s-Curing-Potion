using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershoot : MonoBehaviour
{
    

    public float Mana;
    public Camera cam;
    public GameObject bullet;
    public GameObject smallbullet;
    public bool FIRSTPERSONACHECK;
    public bool smallmode;
    


    void Update()
    {
        FIRSTPERSONACHECK = gameObject.GetComponent<Activate1stPersona>().ILLUSEMYPERSONA;

        if(smallmode == true)
        {
            if(Input.GetMouseButtonDown(0) && FIRSTPERSONACHECK == true)
        {
            GameObject smallbulletObject = Instantiate(smallbullet);
            smallbulletObject.transform.position = cam.transform.position + cam.transform.forward;
            smallbulletObject.transform.forward = cam.transform.forward;
        }
        }
            else
        {
        if(Input.GetMouseButtonDown(0) && FIRSTPERSONACHECK == true && Mana >= 1)
        {
            GameObject bulletObject = Instantiate(bullet);
            bulletObject.transform.position = cam.transform.position + cam.transform.forward;
            bulletObject.transform.forward = cam.transform.forward;
            Mana -= 1;
        }
        else if(Input.GetMouseButtonDown(0) && FIRSTPERSONACHECK == true && Mana <= 1)
        {
            GameObject smallbulletObject = Instantiate(smallbullet);
            smallbulletObject.transform.position = cam.transform.position + cam.transform.forward;
            smallbulletObject.transform.forward = cam.transform.forward;
        }
        }


        if(smallmode == true && Input.GetKeyDown("c")) {smallmode = false;}
        else if(smallmode == false && Input.GetKeyDown("c")) {smallmode = true;}
    }
}
