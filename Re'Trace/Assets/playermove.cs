using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {

    public int playerSpeed = 10;
    private bool InAir;
    private bool facingRight = true;
    public int playerJumpPower = 1250;
    public float moveX;

    void Update() {
        playerMove();
    }
    void playerMove() {
        //controls
        moveX = Input.GetAxis("Horizontal");

        //animations
        //player direction
        if (Input.GetButtonDown("Jump")&& InAir ==false) {
            jump();
        }
        if (moveX < 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == false) {
            FlipPlayer();
        }
        //
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
     
    
    }
    void jump()
    {
       
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        
    }

    void FlipPlayer() {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;

        
       


    }
    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Untagged" && InAir == true)
        {
            InAir = false;
        }
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Untagged" && InAir == true)
        {
            InAir = false;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        InAir = true;
    }
   
}
