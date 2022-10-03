using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public Text scre1;
    public Text scre2;

    public Text winner;

    public GameObject gameOver;

    
    int score1, score2;

    

    

    private void Update()
    {
        score1 = int.Parse(scre1.text);
        score2 = int.Parse(scre2.text);

        if(score1 == 10)
        {
            winner.text = "Player 1 Wins";
            gameOver.SetActive(true);

            Time.timeScale = 0;
        }
        else if(score2 == 10)
        {
            winner.text = "Player 2 Wins";
            gameOver.SetActive(true);

            Time.timeScale = 0;
        }
    }
}
