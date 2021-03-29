using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject startButton;
    public GameObject startButtonHover;

    public static bool StartIsPressed = false;

    public static bool MouseHoverStart = false;

    void OnMouseEnter()
    {
        MouseHoverStart = true;
        
    }
    void OnMouseExit()
    {
        MouseHoverStart = false;
        
    }
    void OnMouseDown()
    {
        StartIsPressed = true;
    }
    void Update()
    {
        if (MouseHoverStart)
        {
            startButton.SetActive(false);
            startButtonHover.SetActive(true);
        }
        else if (MouseHoverStart == false)
        {
            startButton.SetActive(true);
            startButtonHover.SetActive(false);
        }
    }
    
}
