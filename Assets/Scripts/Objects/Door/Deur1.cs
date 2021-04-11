using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deur1 : MonoBehaviour
{
    public PickUp pickUp;

    bool HasRekKey = false;

    public bool PlayerIsNearDoor = false;

    float PosGameCharX;
    float PosGameCharY;

    float XPosPressE;
    float YPosPressE;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerIsNearDoor = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerIsNearDoor = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        pickUp = GameObject.FindObjectOfType<PickUp>();   
    }

    // Update is called once per frame
    void Update()
    {
        PosGameCharX = GameObject.Find("[Untitled] GameChar").transform.position.x;
        PosGameCharY = GameObject.Find("[Untitled] GameChar").transform.position.y;

        //sets positioning of new PressE position every frame
        XPosPressE = PosGameCharX + 1.75f;
        YPosPressE = PosGameCharY + 1;

        if (HasRekKey && PlayerIsNearDoor)
        {
            
            GameObject.Find("PressE").transform.position = new Vector3(XPosPressE, YPosPressE, -2);

            if (Input.GetKeyDown(KeyCode.E))
            {
                SoundManager.PlaySound("DoorOpens");
                Destroy(gameObject);
            }
        }

        for(int i = 0; i < pickUp.Inventory.Length; i++)
        {
            if(pickUp.Inventory[i] == "RedKey")
            {
                HasRekKey = true;
                i = pickUp.Inventory.Length + 1;
            }
        }
    }
}
