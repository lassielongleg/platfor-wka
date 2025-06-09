using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float moveSpeed = 5;
    public float runSpeed = 8;
    public float jumpForce = 300;
    public Rigidbody2D rb;
    public bool isGrounded; 
    public GroundCheckers groundCheckers;
    public playrhealh health;
    public Animator anim;
    public SpriteRenderer spriteRenderer;


    void Start()
    {
      rb =  GetComponent<Rigidbody2D>();
        health = GetComponent<playrhealh>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (health.isDead) return;

       float moveInput = Input.GetAxis("Horizontal");
        if (moveInput >= 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveInput < 0)
        {  
            spriteRenderer.flipX = true;
        }

        if(moveInput != 0)
        {
            anim.SetBool("isRun",true);
        }
        else
        {
            anim.SetBool("isRun",false);
        }
       if(Input.GetKey(KeyCode.LeftShift) )
        {
            rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }


        //Debug.Log($"input value: {moveInput}");
        //rb.velocity = new Vector2(moveInput * moveSpeed,rb.velocity.y);
        if(Input.GetKeyDown(KeyCode.Space) && groundCheckers.isGrounded)
            {
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }
}
