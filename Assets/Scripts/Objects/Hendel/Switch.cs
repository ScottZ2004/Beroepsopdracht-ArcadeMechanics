using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool PlayerIsNearSwitch = false;

    float PosGameCharX;
    float PosGameCharY;

    float XPosPressE;
    float YPosPressE;

    bool SwitchIsUp = true;
    bool SwitchIsDown = false;

    public GameObject HendelOmhoog;
    public GameObject HendelOmlaag;

    public GameObject Licht1;
    public GameObject Licht2;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerIsNearSwitch = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerIsNearSwitch = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PosGameCharX = GameObject.Find("[Untitled] GameChar").transform.position.x;
        PosGameCharY = GameObject.Find("[Untitled] GameChar").transform.position.y;

        //sets positioning of new PressE position every frame
        XPosPressE = PosGameCharX + 1.75f;
        YPosPressE = PosGameCharY + 1;

        if (PlayerIsNearSwitch)
        {
            GameObject.Find("PressE").transform.position = new Vector3(XPosPressE, YPosPressE, -2);

            if (Input.GetKeyDown(KeyCode.E))
            {
                SoundManager.PlaySound("SwitchLever");
                if (SwitchIsUp)
                {
                    HendelOmhoog.SetActive(false);
                    HendelOmlaag.SetActive(true);
                    SwitchIsUp = false;
                    SwitchIsDown = true;
                }
                else if (SwitchIsDown)
                {
                    HendelOmhoog.SetActive(true);
                    HendelOmlaag.SetActive(false);
                    SwitchIsUp = true;
                    SwitchIsDown = false;
                }
            }
        }

        if (SwitchIsUp)
        {
            Licht1.SetActive(true);
            Licht2.SetActive(false);
        }
        else if (SwitchIsDown)
        {
            Licht1.SetActive(false);
            Licht2.SetActive(true);
        }
    }
}
