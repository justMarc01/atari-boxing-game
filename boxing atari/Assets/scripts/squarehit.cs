using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squarehit : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "jab")
        {
            Debug.Log("ouh");
        }
    }
}
