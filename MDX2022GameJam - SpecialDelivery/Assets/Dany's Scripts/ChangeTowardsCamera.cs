using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTowardsCamera : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;  
    public Animator anim;
    public Transform plane;
    public Camera cam;

    private const float step = 22.5f;

    public Sprite N, NW, W, SW, S, SE, E, NE;

    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
       
    }

    public void Update()
    {
        var projected = Vector3.ProjectOnPlane(cam.transform.forward, plane.up);
        var angle = Vector3.SignedAngle(projected, plane.forward, plane.up);

        var AbsAngle = Mathf.Abs(angle);

        if (AbsAngle < step) spriteRenderer.sprite = N;
        else if (AbsAngle < step * 3) spriteRenderer.sprite = Mathf.Sign(angle) < 0 ? NW : NE; 
        else if (AbsAngle < step * 5) spriteRenderer.sprite = Mathf.Sign(angle) < 0 ? W : E;
        else if (AbsAngle < step * 7) spriteRenderer.sprite = Mathf.Sign(angle) < 0 ? SW : SE;
        else spriteRenderer.sprite = S;

        if (AbsAngle < step) spriteRenderer.sprite = N;
        else if (AbsAngle < step * 3) spriteRenderer.sprite = Mathf.Sign(angle) < 0 ? NW : NE;
        else if (AbsAngle < step * 5) spriteRenderer.sprite = Mathf.Sign(angle) < 0 ? W : E;
        else if (AbsAngle < step * 7) spriteRenderer.sprite = Mathf.Sign(angle) < 0 ? SW : SE;
        else spriteRenderer.sprite = S;
             


        Billboard(spriteRenderer.transform, cam);
    }
    public void Billboard(Transform character, Camera mainCamera)
    {
        var dir = plane.position - mainCamera.transform.position;
        var LookAtRotation = Quaternion.LookRotation(dir);

        var LookAtRotationOnly_Y = Quaternion.Euler(character.rotation.eulerAngles.x, LookAtRotation.eulerAngles.y, character.eulerAngles.z);
        character.rotation = LookAtRotationOnly_Y;
    }
}
