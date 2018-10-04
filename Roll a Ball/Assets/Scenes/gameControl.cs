using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour {

    public static gameControl control;

    public float health;
    public float money;

     void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if(control != this)
        {
            Destroy(gameObject);

        }    
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Craziness :" + health);
    }
}
