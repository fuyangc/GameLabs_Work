using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("myCoroutine");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator myCoroutine(){
        //do something
        yield return new WaitForSeconds(2);
        //dos omething else

        yield return null;
        //stops
    }
}
