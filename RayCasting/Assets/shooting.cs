using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    public Transform gunEnd;
    private Camera fpsCamera;
    private LineRenderer laserLine;

	// Use this for initialization
	void Start () {
        fpsCamera = GetComponentInChildren<Camera>();
        laserLine = gunEnd.GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire!")){
            Vector3 rayOrigin = fpsCamera.ViewportToWorldPoint(new Vector3(.5f, .5f, .0f));
            RaycastHit hit;

            laserLine.enabled = true;
            laserLine.SetPosition(0, gunEnd.position);
            if (Physics.Raycast(rayOrigin, fpsCamera.transform.forward, out hit)){

                Debug.Log(hit.collider.tag);
                laserLine.SetPosition(1, hit.point);

            }
            else{
                laserLine.SetPosition(1, fpsCamera.transform.forward * 100f);
            }
        }else{
                laserLine.enabled = false;
            }
        }
	}

