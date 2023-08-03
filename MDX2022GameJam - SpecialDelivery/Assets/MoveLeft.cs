using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float speed = 0.2f;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x,
    transform.position.y, transform.position.z + -speed);
    }
}
