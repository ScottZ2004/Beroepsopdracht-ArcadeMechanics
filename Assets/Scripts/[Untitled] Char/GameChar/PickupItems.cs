using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItems : MonoBehaviour
{
    //declare positioning variables
    float PosGameCharX;
    float PosGameCharY;

    //declare positioning of pressE
    float XPosPressE;
    float YPosPressE;

    //declare the inventory of the player
    public string[] Inventory = new string[30];

    //declare these variable
    bool insideTrigger = false;
    public bool CanPickUpItem;
    
    public string nameCollidedGameObject;
    //if player is inside the collider of the red key
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickupableGameObject"))
        {
            insideTrigger = true;
            nameCollidedGameObject = collision.gameObject.name;
            
        }
    }

    //if player gets of the collider of the red key
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickupableGameObject"))
        {
            insideTrigger = false;
            
        }
    }

    //called once every frame
    void Update()
    {
        //sets positioning of char every frame
        PosGameCharX = GameObject.Find("[Untitled] Char").transform.position.x;
        PosGameCharY = GameObject.Find("[Untitled] Char").transform.position.y;

        //sets positioning of new PressE position every frame
        XPosPressE = PosGameCharX + 1.75f;
        YPosPressE = PosGameCharY + 1;

        CanPickUpItem = true;

        if(insideTrigger)
        {
            PickupRedItem();
            
        }else if(insideTrigger == false)
        {
            GameObject.Find("PressE").transform.position = new Vector3(0, 0, 1);
        }
    }
    
    void PickupRedItem()
    {
        //sets the PressE to the position in witch you can see it 
        GameObject.Find("PressE").transform.position = new Vector3(XPosPressE, YPosPressE, -2);
        
        
        if(CanPickUpItem && Input.GetKey(KeyCode.E))
        {
            //Destroy's item so you can't pick it up again
            Destroy(GameObject.Find(nameCollidedGameObject));
            
            //add Red Key to inventory
            for(int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] == "")
                {
                    Inventory[i] = nameCollidedGameObject;
                    i = Inventory.Length + 1;
                }
            }
            CanPickUpItem = false;
            
            
        }
        
    }
    

}
