using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControls : MonoBehaviour
{

    public Rigidbody2D rb;
    public float thrust;
    public float turnThrust;

    public GameObject bullet;
    public float fire;
    public float fireSpeed;

    public float screenTop;
    public float screenBottom;
    public float screenLeft;
    public float screenRight;

    private float thrustInput;
    private float turnInput;
    public float death;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check input from keyboard 
        thrustInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
        //screen wrapping
        transform.Rotate(Vector3.forward * turnInput * Time.deltaTime * -turnThrust);

        Vector2 newPos = transform.position;
        if (transform.position.y > screenTop)
        {
            newPos.y = screenBottom;
        }
        if (transform.position.y < screenBottom)
        {
            newPos.y = screenTop;
        }

        if (transform.position.x < screenLeft)
        {
            newPos.x = screenRight;
        }
        if (transform.position.x > screenRight)
        {
            newPos.x = screenLeft;
        }
        transform.position = newPos;
        //check for input to fire to make bullets
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * fireSpeed);
            Destroy(newBullet, 5.0f);





        }
    }



    void FixedUpdate()
    {
        rb.AddRelativeForce(Vector2.up * thrustInput);


    }

    //void check collision 
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.relativeVelocity.magnitude > death)
        {
            Debug.Log("You Die");
            Destroy(gameObject);
        }
    }
}

