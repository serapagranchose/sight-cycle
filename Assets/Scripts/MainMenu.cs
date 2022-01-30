using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SettingsButton()
    {

    }

    public void ExitButton()
    {
        Application.Quit();
    }


    // Start is called before the first frame update
}
