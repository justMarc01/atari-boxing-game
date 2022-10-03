using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punch : MonoBehaviour
{
    

    public GameObject upbox;
    public GameObject downbox;

    public GameObject uphand;
    public GameObject downHand;

    public bool jabbing1 = false;
    public bool jabbing2 = false;

    
    public void Punch1()
    {
        if(jabbing1 == false && jabbing2 == false)
        {
            uphand.transform.localScale = new Vector3(1.06f, 0.46f, 1);
            jabbing1 = true;
            upbox.SetActive(true);
            Invoke("returnUpJab", 0.5f);
        }
    }
    public void Punch2()
    {
        if (jabbing1 == false && jabbing2 == false)
        {
            downHand.transform.localScale = new Vector3(1.06f, 0.46f, 1);
            jabbing2 = true;
            downbox.SetActive(true);
            Invoke("returnDownJab", 0.5f);
        }
    }

    void returnUpJab()
    {
        uphand.transform.localScale = new Vector3(1, 0.46f, 1);
        upbox.SetActive(false);
        jabbing1 = false;

    }
    void returnDownJab()
    {
        downHand.transform.localScale = new Vector3(1, 0.46f, 1);
        downbox.SetActive(false);
        jabbing2 = false;

    }
    
}


