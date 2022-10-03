using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class hit1 : MonoBehaviour
{

    public static hit1 Instance;

    public GameObject player2;

    public bool backingUP = false;

    public Text score1;
    
    int score = 0;

    private void Awake()
    {
        Instance = this;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.name == "upbox1" || collision.collider.name == "downbox1")
        {
            score = score + 1;

            score1.text = score.ToString();

            backingUP = true;

            Invoke("BackingUpReset", 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        score = int.Parse(score1.text);
    }

    void BackingUpReset()
    {
        backingUP = false;

    }
}
