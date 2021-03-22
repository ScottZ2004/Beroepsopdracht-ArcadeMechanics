using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPuzzle : MonoBehaviour
{
    public GameObject Panel;
    public GameObject PanelSmall;


    public Knop1 knop1;
    public Knop2 knop2;
    public Knop3 knop3;
    public Knop4 knop4;
    public Knop5 knop5;
    public Knop6 knop6;
    public Knop7 knop7;
    public Knop8 knop8;
    public Knop9 knop9;
    public Knop10 knop10;
    public Knop11 knop11;
    public Knop12 knop12;
    public Knop13 knop13;
    public Knop14 knop14;
    public Knop15 knop15;
    public Knop16 knop16;


    public InterectWithGameObject Interect;
    //declare folowing variables
    public bool PanelIsUsed = true;
    
    public bool PlayerIsNearPanel = false;
    public bool CanUsePanel = true;
    public bool PanelPuzzelSolved = false;

    public string[] InputPuzzle = new string[4];

    public GameObject Deur;

    // Start is called before the first frame update
    void Start()
    {
        Interect = GameObject.FindObjectOfType<InterectWithGameObject>();

        knop1 = GameObject.FindObjectOfType<Knop1>();
        knop2 = GameObject.FindObjectOfType<Knop2>();
        knop3 = GameObject.FindObjectOfType<Knop3>();
        knop4 = GameObject.FindObjectOfType<Knop4>();
        knop5 = GameObject.FindObjectOfType<Knop5>();
        knop6 = GameObject.FindObjectOfType<Knop6>();
        knop7 = GameObject.FindObjectOfType<Knop7>();
        knop8 = GameObject.FindObjectOfType<Knop8>();
        knop9 = GameObject.FindObjectOfType<Knop9>();
        knop10 = GameObject.FindObjectOfType<Knop10>();
        knop11 = GameObject.FindObjectOfType<Knop11>();
        knop12 = GameObject.FindObjectOfType<Knop12>();
        knop13 = GameObject.FindObjectOfType<Knop13>();
        knop14 = GameObject.FindObjectOfType<Knop14>();
        knop15 = GameObject.FindObjectOfType<Knop15>();
        knop16 = GameObject.FindObjectOfType<Knop16>();
    }
    void Update()
    {

        if(PanelPuzzelSolved == false && InputPuzzle[0] == "Knop 2" && InputPuzzle[1] == "Knop 12" && InputPuzzle[2] == "Knop 6" && InputPuzzle[3] == "Knop 15")
        {
            Debug.Log("Goed gedaan!");
            CanUsePanel = false;
            Destroy(GameObject.Find("Panel Puzzle"));
            Interect.Movement.AbleToMove = true;
            PanelPuzzelSolved = true;
            PanelSmall.GetComponent<BoxCollider2D>().enabled = false;
            Destroy(GameObject.Find("(Tijdelijke) Deur"));
            Deur.SetActive(true);
        }
    }

    public void UsePanel()
    {
        if (CanUsePanel)
        {
            //sets the PressE to the position in witch you can see it 
            GameObject.Find("PressE").transform.position = new Vector3(Interect.XPosPressE, Interect.YPosPressE, -2);

            if (Input.GetKeyDown(KeyCode.E) && PanelIsUsed)
            {
                PanelIsUsed = false;
                Interect.Movement.AbleToMove = false;
                GameObject panel = Instantiate(Panel, new Vector3(Interect.PosGameCharX - 1.5f, Interect.PosGameCharY - 2.25f, -14), Quaternion.identity);
                panel.name = "Panel Puzzle";
                
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                Destroy(GameObject.Find("Panel Puzzle"));
                Interect.Movement.AbleToMove = true;
                PanelIsUsed = true;
                for (int i = 0; i < InputPuzzle.Length; i++)
                {
                    InputPuzzle[i] = "";
                }
                

            }
                

        }
    }
}
