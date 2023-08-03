using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    public GameObject spawnObject;
    public int timeTilNextSpawn = 5;
    float timer = 0;

    void Start()
    {
        timer = 0;     
    }

    private void Update()
    {
        timer += Time.deltaTime;
        Spawn();
    }

    void Spawn()
    {
        if (timer >= timeTilNextSpawn)
        {
             
            Instantiate(spawnObject, this.transform.position, Quaternion.identity);
            timer = 0;
        }
    }
}
