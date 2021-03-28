using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop5 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop5;
    public GameObject knop5Pressed;
    public bool Knop5IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop5IsPressed == false)
            {
                SoundManager.PlaySound("ButtonPressed");
                Panel.InputPuzzle[i] = "Knop 5";
                i = Panel.InputPuzzle.Length + 1;
                Knop5IsPressed = true;
                knop5.SetActive(false);
                knop5Pressed.SetActive(true);
            }
        }
    }
}
