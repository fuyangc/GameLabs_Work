using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch : MonoBehaviour {



   public void sceneSwitch(){

        SceneManager.LoadScene("level 1");
        deathscore.scoreValue = 0;
    }
}
