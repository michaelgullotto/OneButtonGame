using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        // set resolution on start phone screen shape
        Screen.SetResolution(412, 732, Screen.fullScreen);
    }

    public void Playgame()
    {
        // load scene from main menu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quitgame()
    {
        // quits game from main menu
        Debug.Log("quit");
        Application.Quit();

    }


}
