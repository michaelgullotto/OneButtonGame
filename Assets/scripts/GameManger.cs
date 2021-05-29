using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManger : MonoBehaviour
{
    public GameObject gameOverCanvas;
    private void Start()
    {
        Screen.SetResolution(412, 732, Screen.fullScreen);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        pausemenu.Gameoverstate = true;
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;

    }
  
        public void Restart()
    {
        pausemenu.Gameoverstate = false;
        SceneManager.LoadScene(1);
        
    }
    
}
