using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop1 : MonoBehaviour
{
    public PanelPuzzle Panel;
    public GameObject knop1;
    public GameObject knop1Pressed;
    public bool Knop1IsPressed = false;
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();
        
    }
    void OnMouseDown()
    {
        for(int i = 0; i < Panel.InputPuzzle.Length; i++ )
        {
            if (Panel.InputPuzzle[i] == "" && Knop1IsPressed == false)
            {
                SoundManager.PlaySound("ButtonPressed");
                Panel.InputPuzzle[i] = "Knop 1";
                i = Panel.InputPuzzle.Length + 1;
                Knop1IsPressed = true;
                knop1.SetActive(false);
                knop1Pressed.SetActive(true);
            }
        }
    }
}
