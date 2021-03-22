using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour
{
    public PanelPuzzle panelpuzzle;


    void Start()
    {
        panelpuzzle = GameObject.FindObjectOfType<PanelPuzzle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        for (int i = 0; i < panelpuzzle.InputPuzzle.Length; i++)
        {
            panelpuzzle.InputPuzzle[i] = "";
        }
        Destroy(GameObject.Find("Panel Puzzle"));
        GameObject panel = Instantiate(panelpuzzle.Panel, new Vector3(panelpuzzle.Interect.PosGameCharX - 1.5f, panelpuzzle.Interect.PosGameCharY - 2.25f, -14), Quaternion.identity);
        panel.name = "Panel Puzzle";
    }
}
