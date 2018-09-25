using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inv : MonoBehaviour
{

    void Update()
    {

        gameObject.GetComponent<Renderer>().enabled = false;
    }

}
