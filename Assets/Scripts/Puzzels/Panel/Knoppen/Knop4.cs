using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop4 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop4;
    public GameObject knop4Pressed;
    public bool Knop4IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();

    }

    void OnMouseDown()
    {
        for (int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            if (Panel.InputPuzzle[i] == "" && Knop4IsPressed == false)
            {
                Panel.InputPuzzle[i] = "Knop 4";
                i = Panel.InputPuzzle.Length + 1;

                Knop4IsPressed = true;
                knop4.SetActive(false);
                knop4Pressed.SetActive(true);
            }
        }
    }
}
