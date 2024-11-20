using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float jumpForce = 5f; // Force applied for jumping
    public Transform groundCheck; // Transform to check if the player is on the ground
    public float checkRadius = 0.2f; // Radius for ground check
    public LayerMask groundLayer; // Layer for ground detection

    private Rigidbody2D rb;
    public bool isGrounded = false;

    public float speed = 5;

    public float fallSepeed;
    public Vector2 move;
    //public float jump = 20;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody component
    }

    // Update is called once per frame
   

    void Update()
    {



        if (Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        
        
        
        
        
        
        // Check for jump input
        if(isGrounded && Input.GetKeyDown(KeyCode.Space)) // Default jump button is space
        {
            print("du hopper");
            Jump();
        }
    }

    void Jump()
    {
        // Apply upward force for jumping
        rb.AddForce( new Vector2(0,jumpForce), ForceMode2D.Impulse);
        print(("snegfl"));
    
    
        
    }

    private void FixedUpdate()
    {
        rb.velocity  = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y) ;
        
        
    }

    
}
