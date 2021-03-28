using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop12 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop12;
    public GameObject knop12Pressed;
    public bool Knop12IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop12IsPressed == false)
            {
                SoundManager.PlaySound("ButtonPressed");
                Panel.InputPuzzle[i] = "Knop 12";
                i = Panel.InputPuzzle.Length + 1;
                Knop12IsPressed = true;
                knop12.SetActive(false);
                knop12Pressed.SetActive(true);
            }
        }
    }
}
