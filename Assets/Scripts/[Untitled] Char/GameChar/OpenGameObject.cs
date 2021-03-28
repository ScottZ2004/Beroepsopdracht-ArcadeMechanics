using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGameObject : MonoBehaviour
{
    //link this script to interect
    public InterectWithGameObject Interect;

    // make gameobjects
    public GameObject WasmachineDicht1;
    public GameObject WasmachineOpen1;

    public GameObject WasmachineDicht2;
    public GameObject WasmachineOpen2;

    //declare folowing variables
    public bool Washingmachine1Open = false;
    public bool Washingmachine2Open = false;

    public bool CharIsOnTriggerOpen = false;
    public bool CanOpenGameObject;

    public string nameCollidedGameObjectOpen;
    // Start is called before the first frame update
    void Start()
    {
        Interect = GameObject.FindObjectOfType<InterectWithGameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        //sets the PressE to the position in witch you can see it 
        GameObject.Find("PressE").transform.position = new Vector3(Interect.XPosPressE, Interect.YPosPressE, -2);

        if (CanOpenGameObject && Input.GetKeyDown(KeyCode.E))
        {
            if (nameCollidedGameObjectOpen == "WasMachine Dicht 1")
            {
                SoundManager.PlaySound("Open");
                WasmachineDicht1.SetActive(false);
                WasmachineOpen1.SetActive(true);
                Washingmachine1Open = true;
            }
            else if (nameCollidedGameObjectOpen == "WasMachine Open 1")
            {
                SoundManager.PlaySound("Close");
                WasmachineOpen1.SetActive(false);
                WasmachineDicht1.SetActive(true);
                Washingmachine1Open = false;
            }

        }

        if (CanOpenGameObject && Input.GetKeyDown(KeyCode.E))
        {
            if (nameCollidedGameObjectOpen == "WasMachine Dicht 2")
            {
                SoundManager.PlaySound("Open");
                WasmachineDicht2.SetActive(false);
                WasmachineOpen2.SetActive(true);
                Washingmachine2Open = true;
            }
            else if (nameCollidedGameObjectOpen == "WasMachine Open 2")
            {
                SoundManager.PlaySound("Close");
                WasmachineOpen2.SetActive(false);
                WasmachineDicht2.SetActive(true);
                Washingmachine2Open = false;
            }

        }
    }
}
