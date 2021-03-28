using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop2 : MonoBehaviour
{
    public PanelPuzzle Panel;

    public GameObject knop2;
    public GameObject knop2Pressed;

    public bool Knop2IsPressed;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop2IsPressed == false)
            {
                SoundManager.PlaySound("ButtonPressed");
                Panel.InputPuzzle[i] = "Knop 2";
                i = Panel.InputPuzzle.Length + 1;
                Knop2IsPressed = true;
                knop2.SetActive(false);
                knop2Pressed.SetActive(true);
            }
        }
    }
}
