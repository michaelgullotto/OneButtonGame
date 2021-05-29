using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManger : MonoBehaviour
{
    public GameObject gameOverCanvas;
    // sets resolution and time on scence start 
    private void Start()
    {
        Screen.SetResolution(412, 732, Screen.fullScreen);
        Time.timeScale = 1;
    }
    //function for game ending triggered by a collision && Gameover state to stop player resuming game game while dead
    public void GameOver()
    {
        pausemenu.Gameoverstate = true;
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;

    }
        // linked to button to replay game after death
        public void Restart()
    {
        pausemenu.Gameoverstate = false;
        SceneManager.LoadScene(1);
        
    }
    
}
