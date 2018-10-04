using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeAction : MonoBehaviour {
    
    
    public Slider cubeCount;
    public Text winText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        float value = cubeCount.value;
        cubeCount.value = value + 1;
        Destroy(this.gameObject); // removes cube on click
        //wintext
        if (cubeCount.value <= 1)
        {

            winText.text = "";
        }
        else if (cubeCount.value == 5 ){

            winText.text = "You win";
        }




    }


}
