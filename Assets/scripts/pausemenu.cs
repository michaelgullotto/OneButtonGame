using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuState;
    public static bool Gameoverstate = false;


   
    void Update()
    {
        // setup to pause and resume game on esc press but disabled while player is dead

        if (Input.GetKeyDown(KeyCode.Escape) && Gameoverstate != true) 
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    // resume and pause function pauses and resumes time when paused and unpaused
    public void Resume()
    {
            pauseMenuState.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        
    }
    public void Pause()
    {
        pauseMenuState.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    // Loads mainmenu linked to button
    public void LoadMenu()
    { 
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainmenu");
        GameIsPaused = (false);
    }
    // Quits game linked to button
    public void QuitGame()
    {
        Application.Quit();
    }
}
