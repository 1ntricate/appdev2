using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string player_name;
    public int player_coins;
}

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb; 
    private SpriteRenderer sprite;
    private Animator anim;
    private float movement;
    private float moveSpeed;
    private float jumpHeight;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();  //to make sprite turn around/flip
        moveSpeed = 9f;
        jumpHeight = 12f;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movement * moveSpeed, rb.velocity.y);

        if(Input.GetButtonDown("Jump")) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight); //2nd argument is vertical height
        }
        UpdateAnimationState();

    }

    private void UpdateAnimationState()
    {
        if (movement > 0f) //if character is moving right
        {
            anim.SetBool("running", true);
            sprite.flipX = false; //unflip sprite
        }
        else if (movement < 0f) //if character is moving left
        {
            anim.SetBool("running", true);
            sprite.flipX = true; //flip sprite
        }
        else // if character is not moving
        {
            anim.SetBool("running", false);
        }        

    }
}
