using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickuItems : MonoBehaviour
{
    //declare the inventory of the player
    public string[] Inventory = new string[30];
    //declare these variable
    bool insideTrigger = false;
    public bool kanItemOppakken = true;
    
    //if player is inside the collider of the red key
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickupableGameObject"))
        {
            insideTrigger = true;
            
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

        if(insideTrigger)
        {
            KanItemOppakken();
        }
    }
    
    void KanItemOppakken()
    {
        
        //sets the PressE to the position in witch you can see it 
        GameObject.Find("PressE").transform.position = new Vector3(0, 0, -2);
        
        
        if(kanItemOppakken && Input.GetKey(KeyCode.E))
        {
            Debug.Log("Je klikt op e");
            Destroy(GameObject.Find("RedKey"));
            
            //add Red Key to inventory
            for(int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] == "")
                {
                    Inventory[i] = "Red Key";
                    i = Inventory.Length + 1;
                }
            }
            
            kanItemOppakken = false;
        }
        
    }
    

}
