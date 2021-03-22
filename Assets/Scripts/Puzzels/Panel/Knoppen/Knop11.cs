using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop11 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop11;
    public GameObject knop11Pressed;
    public bool Knop11IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop11IsPressed == false)
            {
                Panel.InputPuzzle[i] = "Knop 11";
                i = Panel.InputPuzzle.Length + 1;
                Knop11IsPressed = true;
                knop11.SetActive(false);
                knop11Pressed.SetActive(true);
            }
        }
    }
}
