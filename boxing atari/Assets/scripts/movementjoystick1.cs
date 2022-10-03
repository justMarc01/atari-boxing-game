using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movementjoystick1 : MonoBehaviour
{
    public GameObject joystick;
    public GameObject joystickBG;

    public Vector2 joystickvec;
    private Vector2 joystickTouchPos;
    private Vector2 joystickoriginalPos;
    private float joystickRadius;


    void Start()
    {
        joystickoriginalPos = joystickBG.transform.position;
        joystickRadius = joystickBG.GetComponent<RectTransform>().sizeDelta.y / 2;
    }

    public void PointerDown()
    {
        joystick.transform.position = Input.mousePosition;
        joystickBG.transform.position = Input.mousePosition; //+ new Vector3(-65,-65, 0);
        joystickTouchPos = Input.mousePosition;
    }

    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joystickvec = (dragPos - joystickTouchPos).normalized;

        float joystickDist = Vector2.Distance(dragPos, joystickTouchPos);

        if (joystickDist < joystickRadius)
        {
            joystick.transform.position = joystickTouchPos + joystickvec * joystickDist;
        }
        else
        {
            joystick.transform.position = joystickTouchPos + joystickvec * joystickRadius;
        }
    }

    public void PointerUp()
    {
        joystickvec = Vector2.zero;
        joystick.transform.position = joystickoriginalPos;
        joystickBG.transform.position = joystickoriginalPos;// + new Vector2(-65,-65);
    }
}
