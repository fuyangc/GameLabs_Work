using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public int count = 0;
    public static score scorer;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Fire1")){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)){
                Debug.Log(hit.collider.gameObject.tag);
                if(hit.collider.gameObject.tag == "collect"){

                    increaseScore();
                }

            }


        }
	}

    public void increaseScore(){
        count++;
        Debug.Log(count);


    }
}
