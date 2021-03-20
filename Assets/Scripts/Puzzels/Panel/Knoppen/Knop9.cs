using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop9 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop9;
    public GameObject knop9Pressed;
    public bool Knop9IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop9IsPressed == false)
            {
                Panel.InputPuzzle[i] = "Knop 9";
                i = Panel.InputPuzzle.Length + 1;
                Knop9IsPressed = true;
                knop9.SetActive(false);
                knop9Pressed.SetActive(true);
            }
        }
    }
}
