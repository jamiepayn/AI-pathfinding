using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallThrow: MonoBehaviour
{
    public float moveSpeedX;
    public float moveSpeedZ;
    public float moveSpeedY;
    public Vector3 offset;
    
    public GameObject ball;
    public GameObject ballHand;
    public GameObject ballMouth;
    public GameObject huckball;
    public Transform ballInitialPosition;

    Rigidbody rb;
    BoxCollider bc;
    Animator anim;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        bc = transform.GetComponent<BoxCollider>();
        anim = GetComponent<Animator>();
        
        
    }


    void Update()
    {

        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -moveSpeedZ);
            //anim.SetBool("walk left", true);
        }
        
  
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, moveSpeedZ);
   
        }
        
        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector3(-moveSpeedX, rb.velocity.y, rb.velocity.z);
        }
        

        

        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector3(+moveSpeedX, rb.velocity.y, rb.velocity.z);
        }

        
        if (Input.GetKey("space"))
        {
            
            anim.SetTrigger("trigger");
        }

    }

    public void Ballhand()
    {
        ballHand.SetActive(true);

    }

    public void BallMouth()
    {
        ballHand.SetActive(false);
        ballMouth.SetActive(true);
    }

    public void Huck()
    {
     ballMouth.SetActive(false);
     GameObject ball = Instantiate(huckball, ballInitialPosition.position,transform.rotation);



     Rigidbody rb = ball.GetComponent<Rigidbody>();
     rb.AddForce(transform.forward*1, ForceMode.Impulse);
     rb.AddForce(transform.up*2, ForceMode.Impulse);

    }


}


