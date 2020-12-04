using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour


    public float jumpForce;
    public float jumpTime;
    public float jumpTimeCounter;

    public bool grounded;
    public LayerMask whatIsGround;
    public bool stoppedJumping;


    public Transform groundCheck;
    public float groundCheckRadius;

    private Rigidbody2D rb;

void Start()
{
    jumpTimeCounter = jumpTime;
}

void Update()
{
    grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);


    
    if (grounded)
    {
       
        jumpTimeCounter = jumpTime;
    }
}

void FixedUpdate()
{
    if (Input.GetMouseButtonDown(0))
    {
        
        if (grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            stoppedJumping = false;
        }
    }

    if ((Input.GetMouseButton(0)) && !stoppedJumping)
    {
       
        if (jumpTimeCounter > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpTimeCounter -= Time.deltaTime;
        }
    }

    if (Input.GetMouseButtonUp(0))
    {
        jumpTimeCounter = 0;
        stoppedJumping = true;
    }
}
}

}
