using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpable : MonoBehaviour
{
    public LayerMask groundLayer;
    public float jumpPower = 5f;


    public bool checkGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.5f;
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            //if (hit.collider.gameObject.tag == "Ground" || hit.collider.gameObject.tag == "Box")
            if (hit.collider.gameObject.tag == "Ground")
                return true;
            else
                return false;
        }
        else
        {
            return false;
        }
    }
    public bool canJump(){
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.5f;
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (checkGrounded())
            return true;
        //else if(hit.collider.gameObject.tag == "Box")
            //return true;
        else
            return false;
    }
    public void jump(Rigidbody2D rb)
    {
        if (canJump())
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
    }
}
