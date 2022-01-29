using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Spawn : MonoBehaviour
{
    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player2").transform.position = transform.position;
    }

    public void Respawn()
    {
        GameObject.FindGameObjectWithTag("Player2").transform.position = transform.position;
    }
}
