using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision other)
    {
        Debug.Log("Object Touched");
	}

    void OnCollisionStay(Collision other)
    {
        Debug.Log("Object Actively Touched");
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "sphere") {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (other.gameObject.tag == "tag"){
            GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        }
      
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("Object No Longer Touched");
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    public float upforce;

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
      
    }
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
    private void OnTriggerStay(Collider other)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
}   
