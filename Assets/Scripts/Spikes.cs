using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public SpawnPlayer SpawnPlayer;
    public Player2Spawn SpawnPlayer2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            SpawnPlayer.Respawn();
            SpawnPlayer2.Respawn();
        }

        if (collision.CompareTag("Player2"))
        {
            SpawnPlayer.Respawn();
            SpawnPlayer2.Respawn();

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
