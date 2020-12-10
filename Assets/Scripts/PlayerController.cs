using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    public Vector2 movement;
    public bool isOnGround = true;
    public float playerSpeed; 
    public Vector2 jumpHeight;



    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Input.GetKeyDown(KeyCode.W) && isOnGround)
         {
           isOnGround = false;
         }

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.W))  //makes player jump
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.AddForce(direction * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
