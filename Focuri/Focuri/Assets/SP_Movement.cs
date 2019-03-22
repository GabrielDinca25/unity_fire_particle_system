using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP_Movement : MonoBehaviour
{
    public float speed;
    public float rotSpeed = 80;


    private Rigidbody rb;
    public CharacterController cc;
    public Animation anim;
    public AnimationClip Walk;
    public AnimationClip Idle;
    public AnimationClip running;

    private bool once;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, rb.velocity.y, moveVertical);
        Debug.Log(movement);


        if (Input.GetKey(KeyCode.LeftShift) && (movement.z != 0 || movement.x != 0))
        {
            if (!once)
            {
                anim.clip = running;
                anim.Play();
                once = true;
                speed = 4;
            }
        }
        else
        {
            Debug.Log("m");
            once = false;
            if (movement.z != 0 || movement.x != 0)
            {
                anim.clip = Walk;
                anim.Play();
            }
            else
            {
                anim.clip = Idle;
                anim.Play();
            }
            speed = 2;
        }
        cc.Move(movement * Time.deltaTime * speed);
        
    }
}
