using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByHouse : MonoBehaviour
{
    public Animator anim;
    public GameObject exclamation;
    public ParticleSystem flames;
    public GameObject groundFlames;

    public GameObject canvas;

    public Transform target;
    public float t;
    public float speed;


    void Start()
    {     
        flames.Stop();
        StartCoroutine(Kill());
    }
    private void Update()
    {
        Move();
    }

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(3f);
        anim.SetTrigger("Stop");
        exclamation.SetActive(true);
        yield return new WaitForSeconds(2f);
        exclamation.SetActive(false);
        flames.Play();
        yield return new WaitForSeconds(0.5f);
        anim.SetTrigger("Burn");
        yield return new WaitForSeconds(4f);
        groundFlames.SetActive(true);
        flames.Stop();
        yield return new WaitForSeconds(2f);
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
