using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnim : MonoBehaviour {

    SpriteRenderer sr;
    public Sprite lookRight;
    public Sprite lookLeft;
    public Sprite lookDown;
    public Sprite lookUp;
    public float Speed;
    Rigidbody2D rb;

    // Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {


        // if right 
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sr.sprite = lookRight;
            rb.AddForce(transform.right * Speed, ForceMode2D.Impulse);
        }

        //if left
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sr.sprite = lookLeft;
            rb.AddForce(transform.right * -Speed, ForceMode2D.Impulse);

        }
        //if down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            sr.sprite = lookDown;
        }
        // if up
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            sr.sprite = lookUp;
        }
        else if (Input.GetKey(KeyCode.Space)){
            rb.AddForce(transform.up * 1, ForceMode2D.Impulse);

        }



    }
}
