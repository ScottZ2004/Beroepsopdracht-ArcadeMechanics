using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public InterectWithGameObject Interect;
    //declare these variable
    public bool CharIsOnTriggerPickUp = false;
    public bool CanPickUpItem;

    public string nameCollidedGameObjectPickUp;

    public string[] Inventory = new string[30];

    // Start is called before the first frame update
    void Start()
    {
        Interect = GameObject.FindObjectOfType<InterectWithGameObject>();

    }

    
    public void PickupItem()
    {
        //sets the PressE to the position in witch you can see it 
        GameObject.Find("PressE").transform.position = new Vector3(Interect.XPosPressE, Interect.YPosPressE, -2);


        if (CanPickUpItem && Input.GetKey(KeyCode.E))
        {
            SoundManager.PlaySound("Pickup");
            //Destroy's item so you can't pick it up again
            Destroy(GameObject.Find(nameCollidedGameObjectPickUp));

            //add Red Key to inventory
            for (int i = 0; i < Inventory.Length; i++)
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
}
