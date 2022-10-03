using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{

    public movementjoystick1 movementjoystick;
    public float playerSpeed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    //t
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    private void FixedUpdate()
    {
        if(movementjoystick.joystickvec.y != 0)
        {
            rb.velocity = new Vector2(movementjoystick.joystickvec.x * playerSpeed *Time.deltaTime, movementjoystick.joystickvec.y * playerSpeed * Time.deltaTime);
            
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
