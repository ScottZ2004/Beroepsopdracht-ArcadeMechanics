using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop6 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop6;
    public GameObject knop6Pressed;
    public bool Knop6IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop6IsPressed == false)
            {
                Panel.InputPuzzle[i] = "Knop 6";
                i = Panel.InputPuzzle.Length + 1;
                Knop6IsPressed = true;
                knop6.SetActive(false);
                knop6Pressed.SetActive(true);
            }
        }
    }
}
