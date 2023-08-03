using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkingifallthreepumpkinsaregone : MonoBehaviour
{
    public GameObject Target1; public bool Target1Get;
    public GameObject Target2; public bool Target2Get;
    public GameObject Target3; public bool Target3Get;

    public GameObject Target1UI; 
    public GameObject Target2UI; 
    public GameObject Target3UI; 


    public bool Cleared;

        void Start()
    {
        //GravityButton.SetActive(false);
    }

    void Update()
    {
        if (Target1.activeInHierarchy == false) {Target1Get = true; Target1UI.SendMessage("Collected");}
        if (Target2.activeInHierarchy == false) {Target2Get = true; Target2UI.SendMessage("Collected");}
        if (Target3.activeInHierarchy == false) {Target3Get = true; Target3UI.SendMessage("Collected");}

            if (Target1.activeInHierarchy == false && Target2.activeInHierarchy == false && Target3.activeInHierarchy == false)
             {Cleared = true;}


            
    }
}
