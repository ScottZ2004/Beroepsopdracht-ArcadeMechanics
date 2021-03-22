
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop7 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop7;
    public GameObject knop7Pressed;
    public bool Knop7IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop7IsPressed == false)
            {
                Panel.InputPuzzle[i] = "Knop 7";
                i = Panel.InputPuzzle.Length + 1;
                Knop7IsPressed = true;
                knop7.SetActive(false);
                knop7Pressed.SetActive(true);
            }
        }
    }
}
