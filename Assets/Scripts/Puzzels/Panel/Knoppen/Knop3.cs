using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop3 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop3;
    public GameObject knop3Pressed;
    public bool Knop3IsPressed = false;

    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop3IsPressed == false)
            {
                Panel.InputPuzzle[i] = "Knop 3";
                i = Panel.InputPuzzle.Length + 1;
                Knop3IsPressed = true;
                knop3.SetActive(false);
                knop3Pressed.SetActive(true);
            }
        }
    }
}
