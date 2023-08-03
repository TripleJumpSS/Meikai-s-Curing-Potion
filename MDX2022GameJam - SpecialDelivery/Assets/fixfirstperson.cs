using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixfirstperson : MonoBehaviour
{
    public GameObject Player;
    
    void Update()
    {
        gameObject.transform.position = Player.transform.position;
    }
}
