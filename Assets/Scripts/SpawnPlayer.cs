using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{


    private void Awake()
    {

        GameObject.FindGameObjectWithTag("Player").transform.position = transform.position;
       // GameObject.FindGameObjectWithTag("Camera").transform.position = transform.position;
    }
    public void Respawn()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = transform.position;


    }

}
