using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded;

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag=="Floor")
        {
            isGrounded=true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Floor")
        {
            isGrounded=false;
        }
    }
}
