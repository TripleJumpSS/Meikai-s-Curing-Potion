using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exclaimationgone : MonoBehaviour
{
  


    public float timetowait;


    void Start()
    {
        StartCoroutine(Animation());
    }


    IEnumerator Animation()
    {
        yield return new WaitForSeconds(timetowait);
        Destroy(gameObject);
    }
}