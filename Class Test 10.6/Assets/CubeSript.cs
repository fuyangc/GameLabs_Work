using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSript : MonoBehaviour {

    public GameObject sphere;

    // Use this for initialization
    void Start()
    {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("f"))
        {
            StartCoroutine("Fade");
        }
        StartCoroutine("SphereCheck");
    }

    IEnumerator Fade()
    {
        for (float i = 1f; i >= 0; i -= 0.1f)
        {
            Color currentColor = GetComponent<Renderer>().material.color;
            currentColor.a = i;
            GetComponent<Renderer>().material.color = currentColor;
            yield return null;
        }
    }
    IEnumerator SphereCheck(){
            float dist = Vector3.Distance(transform.position, sphere.transform.position);
            if (dist < 5f){
                Debug.Log("oh boi");
            }else{
                Debug.Log("phew");
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

