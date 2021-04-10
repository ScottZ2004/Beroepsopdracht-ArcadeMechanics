using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterectWithGameObject : MonoBehaviour
{
    
    public GameObject PressE;

    //link these scripts with this script
    public MovementChar Movement;
    public OpenGameObject opengameobject;
    public PickUp pickup;
    public PanelPuzzle panelpuzzle;
    public BoomBox boomBox;

    //declare positioning variables
    public float PosGameCharX;
    public float PosGameCharY;

    //declare positioning of pressE
    public float XPosPressE;
    public float YPosPressE;

    

    
    

    //called in the begining
    void Start()
    {
        //links scripts with eachother
        Movement = GameObject.FindObjectOfType<MovementChar>();
        opengameobject = GameObject.FindObjectOfType<OpenGameObject>();
        pickup = GameObject.FindObjectOfType<PickUp>();
        panelpuzzle = GameObject.FindObjectOfType<PanelPuzzle>();
        boomBox = GameObject.FindObjectOfType<BoomBox>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if tag of colider is PickupableGameObject
        if (collision.gameObject.CompareTag("PickupableGameObject"))
        {
            pickup.CharIsOnTriggerPickUp = true;
            pickup.nameCollidedGameObjectPickUp = collision.gameObject.name;
            
        }

        // if tag of colider is OpenAbleGameObject
        if (collision.gameObject.CompareTag("OpenAbleGameObject"))
        {
            opengameobject.CharIsOnTriggerOpen = true;
            opengameobject.nameCollidedGameObjectOpen = collision.gameObject.name;
        }

        // if tag of colider is Panel
        if (collision.gameObject.CompareTag("Panel"))
        {
            panelpuzzle.PlayerIsNearPanel = true;
            
        }
    }

    //if player gets of the collider of the red key
    private void OnTriggerExit2D(Collider2D collision)
    {
        // if tag of colider is PickupableGameObject
        if (collision.gameObject.CompareTag("PickupableGameObject"))
        {
            pickup.CharIsOnTriggerPickUp = false;
            
        }

        // if tag of colider is OpenAbleGameObject
        if (collision.gameObject.CompareTag("OpenAbleGameObject"))
        {
            opengameobject.CharIsOnTriggerOpen = false;
        }

        // if tag of colider is Panel
        if (collision.gameObject.CompareTag("Panel"))
        {
            panelpuzzle.PlayerIsNearPanel = false;
        }
    }

    

    //called once every frame
    void Update()
    {
        //sets positioning of char every frame
        PosGameCharX = GameObject.Find("[Untitled] GameChar").transform.position.x;
        PosGameCharY = GameObject.Find("[Untitled] GameChar").transform.position.y;

        //sets positioning of new PressE position every frame
        XPosPressE = PosGameCharX + 1.75f;
        YPosPressE = PosGameCharY + 1;

        //sets these booleans to true so you can pick up more items in the game
        pickup.CanPickUpItem = true;
        opengameobject.CanOpenGameObject = true;

        if(pickup.CharIsOnTriggerPickUp)
        {
            //trigers function pickupitem
            pickup.PickupItem();
            
        }
        else if(opengameobject.CharIsOnTriggerOpen)
        {
            //trigers function open
            opengameobject.Open();

        }
        else if(panelpuzzle.PlayerIsNearPanel)
        {
            panelpuzzle.UsePanel();
        }
        else if(pickup.CharIsOnTriggerPickUp == false && opengameobject.CharIsOnTriggerOpen == false && panelpuzzle.PlayerIsNearPanel == false && boomBox.CanInsertCasette == false) 
        {
            GameObject.Find("PressE").transform.position = new Vector3(0 , 0, 2);
        }

        //if washingmachine 1 is open and washingmachine 2 is closed, debug
        if(opengameobject.Washingmachine1Open == true && opengameobject.Washingmachine2Open == false)
        {
            Destroy(GameObject.Find("Asset 4"));
        }
    }

    

    
}
