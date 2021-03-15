using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{

    //declare booleans
    bool PlayerIsNearPanel;
    bool CanUsePanel = true; 
    bool PanelPuzzelSolved = false;

    //declare position of GameChar
    float PosGameCharX;
    float PosGameCharY;

    //declare positioning of pressE
    float XPosPressE;
    float YPosPressE;

    //if player is inside the collider of the red key
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if tag of colider is PickupableGameObject
        if (collision.gameObject.CompareTag("Panel"))
        {
            PlayerIsNearPanel = true;
            
        }
    }

    //if player gets of the collider of the red key
    private void OnTriggerExit2D(Collider2D collision)
    {
        // if tag of colider is PickupableGameObject
        if (collision.gameObject.CompareTag("Panel"))
        {
            PlayerIsNearPanel = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gets the position of the gamechar
        PosGameCharX = GameObject.Find("[Untitled] Char").transform.position.x;
        PosGameCharY = GameObject.Find("[Untitled] Char").transform.position.y;

        //sets positioning of new PressE position every frame
        XPosPressE = PosGameCharX + 1.75f;
        YPosPressE = PosGameCharY + 1;

        if(PlayerIsNearPanel == true)
        {
            UsePanel();
        }
        else if(PlayerIsNearPanel == false)
        {
            GameObject.Find("PressE").transform.position = new Vector3(0, 0, 1);
        }
    }

    void UsePanel()
    {
        if(CanUsePanel)
        {
            //sets the PressE to the position in witch you can see it 
            GameObject.Find("PressE").transform.position = new Vector3(XPosPressE, YPosPressE, -2);
            
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("You are using the panel");
            }
        }
        
        

        
    }

}
