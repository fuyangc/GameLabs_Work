using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
        speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
        float xPos = Input.GetAxis("Horizontal") * speed;
        float yPos = Input.GetAxis("Vertical") * speed;

        xPos *= Time.deltaTime;
        yPos *= Time.deltaTime;

        transform.Translate(xPos, yPos, 0);
	}
}
