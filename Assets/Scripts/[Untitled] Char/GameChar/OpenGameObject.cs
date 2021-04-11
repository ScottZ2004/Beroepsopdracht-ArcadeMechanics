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

    public GameObject WasmachineDicht3;
    public GameObject WasmachineOpen3;

    public GameObject WasmachineDicht4;
    public GameObject WasmachineOpen4;

    public GameObject WasmachineDicht5;
    public GameObject WasmachineOpen5;

    public GameObject WasmachineDicht6;
    public GameObject WasmachineOpen6;


    //declare folowing variables
    public bool Washingmachine1Open = false;
    public bool Washingmachine2Open = false;
    public bool Washingmachine3Open = false;
    public bool Washingmachine4Open = false;
    public bool Washingmachine5Open = false;
    public bool Washingmachine6Open = false;

    public bool CharIsOnTriggerOpen = false;
    public bool CanOpenGameObject;

    public string nameCollidedGameObjectOpen;
    // Start is called before the first frame update
    void Start()
    {
        Interect = GameObject.FindObjectOfType<InterectWithGameObject>();
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

        if (CanOpenGameObject && Input.GetKeyDown(KeyCode.E))
        {
            if (nameCollidedGameObjectOpen == "WasMachine Dicht 3")
            {
                SoundManager.PlaySound("Open");
                WasmachineDicht3.SetActive(false);
                WasmachineOpen3.SetActive(true);
                Washingmachine3Open = true;
            }
            else if (nameCollidedGameObjectOpen == "WasMachine Open 3")
            {
                SoundManager.PlaySound("Close");
                WasmachineOpen3.SetActive(false);
                WasmachineDicht3.SetActive(true);
                Washingmachine3Open = false;
            }

        }

        if (CanOpenGameObject && Input.GetKeyDown(KeyCode.E))
        {
            if (nameCollidedGameObjectOpen == "WasMachine Dicht 4")
            {
                SoundManager.PlaySound("Open");
                WasmachineDicht4.SetActive(false);
                WasmachineOpen4.SetActive(true);
                Washingmachine4Open = true;
            }
            else if (nameCollidedGameObjectOpen == "WasMachine Open 4")
            {
                SoundManager.PlaySound("Close");
                WasmachineOpen4.SetActive(false);
                WasmachineDicht4.SetActive(true);
                Washingmachine4Open = false;
            }

        }

        if (CanOpenGameObject && Input.GetKeyDown(KeyCode.E))
        {
            if (nameCollidedGameObjectOpen == "WasMachine Dicht 5")
            {
                SoundManager.PlaySound("Open");
                WasmachineDicht5.SetActive(false);
                WasmachineOpen5.SetActive(true);
                Washingmachine5Open = true;
            }
            else if (nameCollidedGameObjectOpen == "WasMachine Open 5")
            {
                SoundManager.PlaySound("Close");
                WasmachineOpen5.SetActive(false);
                WasmachineDicht5.SetActive(true);
                Washingmachine5Open = false;
            }

        }

        if (CanOpenGameObject && Input.GetKeyDown(KeyCode.E))
        {
            if (nameCollidedGameObjectOpen == "WasMachine Dicht 6")
            {
                SoundManager.PlaySound("Open");
                WasmachineDicht6.SetActive(false);
                WasmachineOpen6.SetActive(true);
                Washingmachine6Open = true;
            }
            else if (nameCollidedGameObjectOpen == "WasMachine Open 6")
            {
                SoundManager.PlaySound("Close");
                WasmachineOpen6.SetActive(false);
                WasmachineDicht6.SetActive(true);
                Washingmachine6Open = false;
            }

        }
    }
}
