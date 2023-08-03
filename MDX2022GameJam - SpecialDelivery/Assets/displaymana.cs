using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displaymana : MonoBehaviour
{
    public GameObject shooterplayer;
    public Slider ManaBar;
    

    // Update is called once per frame
    void Update()
    {
        ManaBar.value = shooterplayer.GetComponent<Playershoot>().Mana; 
    }
}
