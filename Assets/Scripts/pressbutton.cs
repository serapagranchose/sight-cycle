using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressbutton : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Player")|| collision.CompareTag("Player2"))
        {
            if (GameObject.FindGameObjectWithTag("DOOR").GetComponent<BoxCollider2D>().enabled == true) 
            {
                GameObject.FindGameObjectWithTag("DOOR").GetComponent<BoxCollider2D>().enabled = false;
                GameObject.FindGameObjectWithTag("DOOR").GetComponent<SpriteRenderer>().enabled = false;
            }
            else 
            {
                GameObject.FindGameObjectWithTag("DOOR").GetComponent<BoxCollider2D>().enabled = true;
                GameObject.FindGameObjectWithTag("DOOR").GetComponent<SpriteRenderer>().enabled = true;

            }
        }
    }
}