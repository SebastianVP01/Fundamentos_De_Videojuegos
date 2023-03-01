using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    private Animator animator;
    public float runSpeed=0;

    public float jumpSpeed=3;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
       Rigidbody2D=GetComponent<Rigidbody2D>();
       animator=GetComponent<Animator>();
    }

    // Update is called once per frame
  

    

    void FixedUpdate() 
    {
          
     animator.SetBool("Run", Rigidbody2D.velocity.x!=0);
     animator.SetBool("Grounded",CheckGround.isGrounded );
       if(Input.GetKey("d") || Input.GetKey("right"))
       {
            Rigidbody2D.velocity= new Vector2(runSpeed, Rigidbody2D.velocity.y);
       }
       else if(Input.GetKey("a") || Input.GetKey("left"))
       {
            Rigidbody2D.velocity= new Vector2(-runSpeed, Rigidbody2D.velocity.y);
       }
       else
       {
            Rigidbody2D.velocity=new Vector2(0,Rigidbody2D.velocity.y);
       }

       if(Input.GetKey("space") && CheckGround.isGrounded)
       {
        Rigidbody2D.velocity=new Vector2(Rigidbody2D.velocity.x, jumpSpeed);
        
       }

       if(Rigidbody2D.velocity.x <= 0)
       {
          transform.localScale=new Vector2(-0.42f,0.68f);
       }
       else
       {
          transform.localScale=new Vector2(0.42f,0.68f);
          
       }
          
    }

  
    
    
    
}
