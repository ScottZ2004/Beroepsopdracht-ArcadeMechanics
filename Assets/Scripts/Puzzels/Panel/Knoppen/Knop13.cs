using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop13 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop13;
    public GameObject knop13Pressed;
    public bool Knop13IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop13IsPressed == false)
            {
                SoundManager.PlaySound("ButtonPressed");
                Panel.InputPuzzle[i] = "Knop 13";
                i = Panel.InputPuzzle.Length + 1;
                Knop13IsPressed = true;
                knop13.SetActive(false);
                knop13Pressed.SetActive(true);
            }
        }
    }
}
