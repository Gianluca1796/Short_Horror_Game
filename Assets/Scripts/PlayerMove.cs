using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private new Rigidbody rigidbody;
    public float movementSpeed;
    public AudioSource walk;
    public Animator animator;




    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
       
    }
    
    void Update()
    {   
     
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 velocity = Vector3.zero;
        if( ver != 0 || hor != 0)
        {
            Vector3 direction = (transform.forward * ver  + transform.right * hor).normalized;
            velocity = direction * movementSpeed;
        }
        velocity.y = rigidbody.velocity.y;
        rigidbody.velocity = velocity;



        animator.SetFloat("VelX", hor);
        animator.SetFloat("VelY", ver);




        if(Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
        {
            walk.Play();
        }

        if (Input.GetButtonUp("Horizontal") || Input.GetButtonUp("Vertical"))
        {
            if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
            {
                walk.Play();
            }
            else
            {
                walk.Pause();
            }
        }


    }
}
