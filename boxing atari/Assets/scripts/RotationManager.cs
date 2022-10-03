using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject npc;
    public GameObject reset;


    private float playerX;
    private float npcX;

    

    private float playerScaleX;

    private void Update()
    {
        playerX = player1.transform.position.x;
        npcX = npc.transform.position.x;

        

        if(playerX > npcX)
        {
            player1.transform.localScale = new Vector3(-1, 1, 1);
            npc.transform.localScale = new Vector3(1, 1, 1);

            reset.transform.position = new Vector3(-7, 0.2f, 0);
        }
        else if (playerX < npcX)
        {
            player1.transform.localScale = new Vector3(1, 1, 1);
            npc.transform.localScale = new Vector3(-1, 1, 1);

            reset.transform.position = new Vector3(6.48f, 0.2f, 0);
        }
    }
}
