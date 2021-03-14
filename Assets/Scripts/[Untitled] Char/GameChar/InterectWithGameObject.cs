using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterectWithGameObject : MonoBehaviour
{
    // make gameobjects
    public GameObject WasmachineDicht1;
    public GameObject WasmachineOpen1;

    public GameObject WasmachineDicht2;
    public GameObject WasmachineOpen2;
    

    //declare positioning variables
    float PosGameCharX;
    float PosGameCharY;

    //declare positioning of pressE
    float XPosPressE;
    float YPosPressE;

    //declare the inventory of the player
    public string[] Inventory = new string[30];

    //declare these variable
    bool CharIsOnTriggerPickUp = false;
    bool CharIsOnTriggerOpen = false;
    public bool CanPickUpItem;
    public bool CanOpenGameObject;
    
    //declare the strings
    public string nameCollidedGameObjectPickUp;
    public string nameCollidedGameObjectOpen;

    //declare booleans for puzzle washingmachine
    public bool Washingmachine1Open = false;
    public bool Washingmachine2Open = false;

    //if player is inside the collider of the red key
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if tag of colider is PickupableGameObject
        if (collision.gameObject.CompareTag("PickupableGameObject"))
        {
            CharIsOnTriggerPickUp = true;
            nameCollidedGameObjectPickUp = collision.gameObject.name;
            
        }

        // if tag of colider is OpenAbleGameObject
        if (collision.gameObject.CompareTag("OpenAbleGameObject"))
        {
            CharIsOnTriggerOpen = true;
            nameCollidedGameObjectOpen = collision.gameObject.name;
        }
    }

    //if player gets of the collider of the red key
    private void OnTriggerExit2D(Collider2D collision)
    {
        // if tag of colider is PickupableGameObject
        if (collision.gameObject.CompareTag("PickupableGameObject"))
        {
            CharIsOnTriggerPickUp = false;
            
        }

        // if tag of colider is OpenAbleGameObject
        if (collision.gameObject.CompareTag("OpenAbleGameObject"))
        {
            CharIsOnTriggerOpen = false;
        }
    }

    //called in the begining
    void Start()
    {
        //sets the open wachining machines in the beginning to false
        WasmachineOpen1.SetActive(false);
        WasmachineOpen2.SetActive(false);
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

        //sets these booleans to true so you can pick up more items in the game
        CanPickUpItem = true;
        CanOpenGameObject = true;

        if(CharIsOnTriggerPickUp)
        {
            //trigers function pickupitem
            PickupItem();
            
        }
        else if(CharIsOnTriggerOpen)
        {
            //trigers function open
            Open();
            
        }
        else if(CharIsOnTriggerPickUp == false && CharIsOnTriggerOpen == false)
        {
            GameObject.Find("PressE").transform.position = new Vector3(0, 0, 1);
        }

        //if washingmachine 1 is open and washingmachine 2 is closed, debug
        if(Washingmachine1Open == true && Washingmachine2Open == false)
        {
            Destroy(GameObject.Find("Asset 4"));
        }
    }

    //*under here*
    //these function are if player collides with gameobjects
    
    //this function is if player pickd a item up
    void PickupItem()
    {
        //sets the PressE to the position in witch you can see it 
        GameObject.Find("PressE").transform.position = new Vector3(XPosPressE, YPosPressE, -2);
        
        
        if(CanPickUpItem && Input.GetKey(KeyCode.E))
        {
            //Destroy's item so you can't pick it up again
            Destroy(GameObject.Find(nameCollidedGameObjectPickUp));
            
            //add Red Key to inventory
            for(int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] == "")
                {
                    Inventory[i] = nameCollidedGameObjectPickUp;
                    i = Inventory.Length + 1;
                }
            }
            CanPickUpItem = false;
            
            
        }
        
    }

    //this function is if player opens a gameobject
    void Open()
    {
        //sets the PressE to the position in witch you can see it 
        GameObject.Find("PressE").transform.position = new Vector3(XPosPressE, YPosPressE, -2);

        if (CanOpenGameObject && Input.GetKeyDown(KeyCode.E))
        {
            if (nameCollidedGameObjectOpen == "WasMachine Dicht 1")
            {
                WasmachineDicht1.SetActive(false);
                WasmachineOpen1.SetActive(true);
                Washingmachine1Open = true;
            }
            else if (nameCollidedGameObjectOpen == "WasMachine Open 1")
            {
                WasmachineOpen1.SetActive(false);
                WasmachineDicht1.SetActive(true);
                Washingmachine1Open = false;
            }
            
        }

        if (CanOpenGameObject && Input.GetKeyDown(KeyCode.E))
        {
            if (nameCollidedGameObjectOpen == "WasMachine Dicht 2")
            {
                WasmachineDicht2.SetActive(false);
                WasmachineOpen2.SetActive(true);
                Washingmachine2Open = true;
            }
            else if (nameCollidedGameObjectOpen == "WasMachine Open 2")
            {
                WasmachineOpen2.SetActive(false);
                WasmachineDicht2.SetActive(true);
                Washingmachine2Open = false;
            }
            
        }
    }

    
}
