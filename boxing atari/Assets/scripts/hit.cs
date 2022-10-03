using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class hit : MonoBehaviour
{
    public Text score1;

    
    int score = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.name == "upbox" || collision.collider.name == "downbox") 
        {
            score = score + 1;

            score1.text = score.ToString();
            

            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        score = int.Parse(score1.text);
    }

    
}
