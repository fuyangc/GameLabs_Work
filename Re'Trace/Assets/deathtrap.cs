using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class deathtrap : MonoBehaviour
{
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            Destroy(collision.gameObject);
            StartCoroutine("Die");
        }
    }

    IEnumerator Die() {
        SceneManager.LoadScene("Main");
        deathscore.scoreValue += 1;
        yield return null;

    }
}
