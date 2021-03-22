using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop15 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop15;
    public GameObject knop15Pressed;
    public bool Knop15IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop15IsPressed == false)
            {
                Panel.InputPuzzle[i] = "Knop 15";
                i = Panel.InputPuzzle.Length + 1;
                Knop15IsPressed = true;
                knop15.SetActive(false);
                knop15Pressed.SetActive(true);
            }
        }
    }
}
