using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop16 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop16;
    public GameObject knop16Pressed;
    public bool Knop16IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop16IsPressed == false)
            {
                Panel.InputPuzzle[i] = "Knop 16";
                i = Panel.InputPuzzle.Length + 1;
                Knop16IsPressed = true;
                knop16.SetActive(false);
                knop16Pressed.SetActive(true);
            }
        }
    }
}
