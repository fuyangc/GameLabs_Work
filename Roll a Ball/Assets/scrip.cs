using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invis : MonoBehaviour
{

    void Update()
    {

        gameObject.GetComponent<Renderer>().enabled = false;
    }

}
