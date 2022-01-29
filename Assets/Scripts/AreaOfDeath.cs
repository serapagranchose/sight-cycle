using UnityEngine;

public class AreaOfDeath : MonoBehaviour
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

}
