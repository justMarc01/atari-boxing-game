using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertwomovement : MonoBehaviour
{
    /*
    public Rigidbody2D rb2;

    float moveSpeed = 100f;

    float horizontal;
    float vertical;

    public float invokeTime = 5f;

    public GameObject upJab;
    public GameObject downJab;

    bool jabbing1 = false;
    bool jabbing2 = false;


    public GameObject upbox;
    public GameObject downbox;


    private void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        


            if (Input.GetKey("j"))
            {
                horizontal = -1;

            }
            else if (Input.GetKey("l"))
            {
                horizontal = 1;

            }
            else
            {
                horizontal = 0;
            }


            if (Input.GetKey("i"))
            {
                vertical = 1;
            }
            else if (Input.GetKey("k"))
            {
                vertical = -1;
            }
            else
            {
                vertical = 0;
            }


            if (Input.GetKeyDown("u") && jabbing1 == false)
            {
                upJab.transform.localScale = new Vector3(-1.06f, 0.46f, 1);
                jabbing1 = true;
                Invoke("returnUpJab", invokeTime);
            }

            if (Input.GetKeyDown("o") && jabbing2 == false)
            {
                downJab.transform.localScale = new Vector3(-1.06f, 0.46f, 1);
                jabbing2 = true;
                Invoke("returnDownJab", invokeTime);
            }

            if (jabbing1 == true)
            {
                upbox.SetActive(true);
            }
            else
            {
                upbox.SetActive(false);
            }

            if (jabbing2 == true)
            {
                downbox.SetActive(true);
            }
            else
            {
                downbox.SetActive(false);
            }

        
    }

    private void FixedUpdate()
    {
        rb2.velocity = new Vector2(horizontal * moveSpeed * Time.deltaTime, vertical * moveSpeed * Time.deltaTime);
    }

    void returnUpJab()
    {
        upJab.transform.localScale = new Vector3(-1, 0.46f, 1);

        jabbing1 = false;

    }
    void returnDownJab()
    {
        downJab.transform.localScale = new Vector3(-1, 0.46f, 1);

        jabbing2 = false;

    }
    */
}
