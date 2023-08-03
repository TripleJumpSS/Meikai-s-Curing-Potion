using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CyclopsFieldOfView : MonoBehaviour
{


    

    public bool canSeePlayer;


    public GameObject Player;
    public GameObject model;
    public float speed;
    public float fallspeed;

    //NavMeshAgent agent;





    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canSeePlayer = true;
            
        }
    }

    void FixedUpdate()
    {
       if(canSeePlayer == true)
       {transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Time.deltaTime * speed);
       model.transform.position += -transform.up * Time.deltaTime * fallspeed;
        this.GetComponent<Waypoints>().enabled = false;

            { SceneManager.LoadScene("DeathCutsceneCyclops"); }
        }
    }

    private void OnTriggerEnter(Collision other)
    {
        { SceneManager.LoadScene("DeathCutsceneCyclops"); }
    }





}
