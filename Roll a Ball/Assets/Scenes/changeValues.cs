using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeValues : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 100, 100, 30), "craziness up"))
        {
            gameControl.control.health += 5;
        }
        if (GUI.Button(new Rect(10, 140, 100, 30), "craziness down"))
        {
            gameControl.control.health -= 5;

        }
      

        }

    }
