using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverManager : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        
    }

    public void Home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        
    }

    public void Quit()
    {
        Time.timeScale = 1;
        Application.Quit();
    }

}
