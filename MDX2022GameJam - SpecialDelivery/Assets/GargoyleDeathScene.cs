using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GargoyleDeathScene : MonoBehaviour
{
    public Animator anim;
    public GameObject canvas;
    public GameObject exclamation;
    public GameObject myLight;
    public Transform target;
    public float t;
    public float speed;


    void Start()
    {       
        StartCoroutine(Kill());
    }
    private void Update()
    {
        Move();
    }

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(3f);
        exclamation.SetActive(true);
        myLight.SetActive(true);
        anim.SetTrigger("WTF");
        yield return new WaitForSeconds(6f);
        anim.SetTrigger("Death");
        yield return new WaitForSeconds(1f);
        canvas.SetActive(true);
        yield return null;
    }

    public void Move()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a, b, speed);

    }
}
