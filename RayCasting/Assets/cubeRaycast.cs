using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRaycast : MonoBehaviour {

    public float height = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Debug.DrawRay(transform.position, Vector3.down * 5, Color.green);
        if (Physics.Raycast(transform.position, Vector3.down, out hit, height)){

            Debug.Log("5 or less units from the ground");
            //Debug.Log(hit.collider.tag  );
            if (hit.collider.tag == "Ground"){
                GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }
	}
}
