using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X : MonoBehaviour
{
    public PanelPuzzle Panel;

    // Start is called before the first frame update
    void Start()
    {
        Panel = GameObject.FindObjectOfType<PanelPuzzle>();
    }

    private void OnMouseDown()
    {
        Destroy(GameObject.Find("Panel Puzzle"));
        Panel.Interect.Movement.AbleToMove = true;
        Panel.PanelIsUsed = true;
        for(int i = 0; i < Panel.InputPuzzle.Length; i++)
        {
            Panel.InputPuzzle[i] = "";
        }
    }
}
