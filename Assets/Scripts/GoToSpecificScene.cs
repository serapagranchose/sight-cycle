using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSpecificScene : MonoBehaviour
{
    [SerializeField] string input;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")||collision.CompareTag("Player2")) 
        {
            SceneManager.LoadScene(input);
        }
    }
}
