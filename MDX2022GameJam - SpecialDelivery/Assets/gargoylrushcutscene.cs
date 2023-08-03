using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gargoylrushcutscene : MonoBehaviour
{
  

    public float speed;
    public float timetowait;
    public bool timetogo;

    void Start()
    {
        StartCoroutine(Animation());
    }

    void Update()
    {
        if (timetogo == true)
        {transform.position += transform.right * Time.deltaTime * speed;}
    }

    IEnumerator Animation()
    {
        yield return new WaitForSeconds(timetowait);
        timetogo = true;
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
