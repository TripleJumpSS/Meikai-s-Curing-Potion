using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EyeBall : MonoBehaviour
{
    public float firstAngle;
    public float secondAngle;

    void Start()
    {
        StartCoroutine(rotateForever());
    }

    IEnumerator rotateForever()
    {
        WaitForSeconds waitTime = new WaitForSeconds(5.5f);
        while (true)
        {
            Vector3 transformDown = transform.up * -1.0f;
            StartCoroutine(RotateMe1(Vector3.down * firstAngle, 1f));
            yield return waitTime;
            StartCoroutine(RotateMe2(Vector3.down * secondAngle, 1f));
            yield return waitTime;
        }
    }


    IEnumerator RotateMe1(Vector3 byAngles1, float inTime1)
    {
        var fromAngle1 = transform.rotation;
        var toAngle1 = Quaternion.Euler(transform.eulerAngles + byAngles1);
        for (var t = 0f; t < 1; t += Time.deltaTime / inTime1)
        {
            transform.rotation = Quaternion.Lerp(fromAngle1, toAngle1, t);
            yield return null;
        }
    }

    IEnumerator RotateMe2(Vector3 byAngles2, float inTime2)
    {
        var fromAngle2 = transform.rotation;
        var toAngle2 = Quaternion.Euler(transform.eulerAngles + byAngles2);
        for (var t = 0f; t < 1; t += Time.deltaTime / inTime2)
        {
            transform.rotation = Quaternion.Lerp(fromAngle2, toAngle2, t);
            yield return null;
        }
    }

   
}

