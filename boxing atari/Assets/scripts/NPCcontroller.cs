using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCcontroller : MonoBehaviour
{

    private Rigidbody2D rb;

    public float moveSpeed = 2;
    /*

    public float moveSpeed = 3f;


    public float rotSpeed = 100f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false; 

    private void Update()
    {
        if (isWandering == false)
        {
            StartCoroutine(wander());
        }
        if(isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * moveSpeed);
        }
        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * - moveSpeed);
        }
    }

    IEnumerable wander()
    {
        int rottime = Random.Range(1, 3);
        int rotateWait = Random.Range(1, 4);
        int rotateLorR = Random.Range(1, 2);
        int walkWait = Random.Range(1, 4);
        int walkTime = Random.Range(1, 3);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
        yield return new WaitForSeconds(rotateWait);
        if(rotateLorR == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rottime);
            isRotatingRight = false;
        }
        if(rotateLorR == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rottime);
            isRotatingLeft = false;
        }
        isWandering = false;
    }
    */
    //bool backingUp = false;

    bool jabbing1 = false;
    bool jabbing2 = false;

    float horizontal;
    float vertical;

    public GameObject player1;

    public GameObject upJab;
    public GameObject downJab;

    public GameObject upbox;
    public GameObject downbox;

    public GameObject reset;

    //bool isWalking;

    private float distance;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        /*
        if(isWalking == false)
        {
            
            isWalking = true;
            Invoke("random", 0.5f);
        }
        */

        distance = Vector2.Distance(transform.position, player1.transform.position);


        RandomHit();

        Invoke("DisableJab", 0.2f);

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
        //rb.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
        /*
        if (hit1.Instance.backingUP == false)
        {


            rb.transform.position = Vector2.MoveTowards(transform.position, player1.transform.position, moveSpeed * Time.deltaTime);


        }
        else if (hit1.Instance.backingUP == true)
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, reset.transform.position, moveSpeed * Time.deltaTime);
            


        }
        */
        if(hit1.Instance.backingUP == false)
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, player1.transform.position, moveSpeed * Time.deltaTime);
        }
        else if(hit1.Instance.backingUP == true)
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, reset.transform.position, moveSpeed * Time.deltaTime);
        }
    }

    void RandomHit()
    {
        int x;
        x = Random.Range(1, 3);

        if (x == 1 && jabbing1 == false && jabbing2 == false)
        {
            upJab.transform.localScale = new Vector3(-1.1f, 0.46f, 1);
            jabbing1 = true;
            Invoke("returnUpJab", 0.5f);
        }
        else if (x == 2 && jabbing2 == false && jabbing1 == false)
        {
            downJab.transform.localScale = new Vector3(-1.1f, 0.46f, 1);
            jabbing2 = true;
            Invoke("returnDownJab", 0.5f);
        }
    }


    void random()
    {
        horizontal = Random.Range(-1, 2);
        vertical = Random.Range(-1, 2);

        //isWalking = false;
    }

    void returnUpJab()
    {


        jabbing1 = false;

    }
    void returnDownJab()
    {


        jabbing2 = false;

    }

    void DisableJab()
    {
        upJab.transform.localScale = new Vector3(-1, 0.46f, 1);
        downJab.transform.localScale = new Vector3(-1, 0.46f, 1);
    }

    void BackingUpReset()
    {
        //backingUp = false;

    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "upbox1" || collision.collider.name == "upbox2")
        {


            backingUp = true;
            Invoke("BackingUpReset", 0.5f);
        }
    }
    */
}