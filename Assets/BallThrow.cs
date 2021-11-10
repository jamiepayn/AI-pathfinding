using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallThrow: MonoBehaviour
{
    public float moveSpeedX;
    public float moveSpeedZ;
    public float moveSpeedY;
    
    
    public GameObject ballHand;
    public GameObject ballMouth;
    public GameObject huckball;
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
     Instantiate(huckball, new Vector3(-5.89499998f,2.58699989f,-5.30200005f), Quaternion.identity);
    }


}


