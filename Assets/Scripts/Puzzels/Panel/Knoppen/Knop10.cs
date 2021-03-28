using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop10 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop10;
    public GameObject knop10Pressed;
    public bool Knop10IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop10IsPressed == false)
            {
                SoundManager.PlaySound("ButtonPressed");
                Panel.InputPuzzle[i] = "Knop 10";
                i = Panel.InputPuzzle.Length + 1;
                Knop10IsPressed = true;
                knop10.SetActive(false);
                knop10Pressed.SetActive(true);
            }
        }
    }
}
