using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetbreak : MonoBehaviour
{
    public GameObject Target;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
             Target.SetActive(false);
             print("kablooey");
            }
}

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
