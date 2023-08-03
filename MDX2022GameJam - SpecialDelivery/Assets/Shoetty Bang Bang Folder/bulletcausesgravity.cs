using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcausesgravity : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Rigidbody rig;
    public GameObject box;
    public Rigidbody boxrig;
    public bool BeenShot;
    public bool BeenMiniShot;
    
    void Start()
    {rig = GetComponent<Rigidbody>();
    boxrig = box.GetComponent<Rigidbody>();}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            rig.useGravity = true;
            boxrig.useGravity = true;
            BeenShot = true;
        }
        if (other.gameObject.tag == "MiniBullet")
        {
            boxrig.useGravity = true;
            BeenMiniShot = true;
        }
    }
}
