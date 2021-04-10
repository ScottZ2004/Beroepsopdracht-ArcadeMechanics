using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomBox : MonoBehaviour
{
    public PickUp pickUp;

    public GameObject musicNotes;

    float PosGameCharX;
    float PosGameCharY;

    float XPosPressE;
    float YPosPressE;

    public bool CanInsertCasette = false;

    public static bool BoomBoxIsPlaying = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            for(int i = 0; i < pickUp.Inventory.Length; i++)
            {
                if(pickUp.Inventory[i] == "Casette band")
                {
                    CanInsertCasette = true;
                    i = pickUp.Inventory.Length + 1;
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CanInsertCasette = false;
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
        //sets positioning of char every frame
        PosGameCharX = GameObject.Find("[Untitled] GameChar").transform.position.x;
        PosGameCharY = GameObject.Find("[Untitled] GameChar").transform.position.y;

        //sets positioning of new PressE position every frame
        XPosPressE = PosGameCharX + 1.75f;
        YPosPressE = PosGameCharY + 1;

        if (CanInsertCasette)
        {
            GameObject.Find("PressE").transform.position = new Vector3(XPosPressE, YPosPressE, -2);

            PlayBoomBox();
        }
    }

    void PlayBoomBox()
    {
        if (Input.GetKeyDown(KeyCode.E) && BoomBoxIsPlaying == false)
        {
            BoomBoxIsPlaying = true;
            Instantiate(musicNotes, new Vector3(-3.212f, 1.941f, -1), Quaternion.identity);
        }
    }
}
