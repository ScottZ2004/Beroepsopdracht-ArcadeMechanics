using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop14 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop14;
    public GameObject knop14Pressed;
    public bool Knop14IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop14IsPressed == false)
            {
                Panel.InputPuzzle[i] = "Knop 14";
                i = Panel.InputPuzzle.Length + 1;
                Knop14IsPressed = true;
                knop14.SetActive(false);
                knop14Pressed.SetActive(true);
            }
        }
    }
}
