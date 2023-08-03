using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public Vector3 respawnSafePosition;
    public Vector3 respawnSafeRotation;
    private GameObject PC;

    private DS_Level_Manager levelManagerReference;

    private bool shouldRespawn;


    public Color fadeColor = Color.red;
    public float fadeTime = 5f;




    void Start()
    {
        levelManagerReference = GameObject.Find("LevelManager").GetComponent<DS_Level_Manager>();
    }

   
    void FixedUpdate()
    {
        if (shouldRespawn)
        {
            shouldRespawn = false;
            PC.transform.position = levelManagerReference.lastGoodCheckpoint.position;
            PC.transform.eulerAngles = respawnSafeRotation;   
        }       
                
    }

    public void Fade()
    {
        CameraFade.StartAlphaFade(fadeColor, true, fadeTime);
    }
}
