using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GamaManager : MonoBehaviour
{
    public Button pauseBtn;
    public Button playBtn;


    public GameObject inputCanvas;
    public GameObject scoreCanvas;
    

    public GameObject pauseMenu;


    public void Paused()
    {
        
        pauseBtn.enabled = false;
        
        
        Time.timeScale = 0;

        inputCanvas.SetActive(false);
        scoreCanvas.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void Play()
    {
        pauseBtn.enabled = true;
        

        pauseMenu.SetActive(false);
        inputCanvas.SetActive(true);
        scoreCanvas.SetActive(true);
        Time.timeScale = 1;

        
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void HomeBtn()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    

}
