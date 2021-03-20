using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop8 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop8;
    public GameObject knop8Pressed;
    public bool Knop8IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop8IsPressed == false)
            {
                Panel.InputPuzzle[i] = "Knop 8";
                i = Panel.InputPuzzle.Length + 1;
                Knop8IsPressed = true;
                knop8.SetActive(false);
                knop8Pressed.SetActive(true);
            }
        }
    }
}
