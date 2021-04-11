using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Licht : MonoBehaviour
{
    bool PlayerIsOnLight = false;
    bool PlayerIsDead = false;


    public GameObject youDied;

    int ticks;

    public MovementChar movementChar;

    float YouDiedPosX;
    float YouDiedPosY;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
           
            PlayerIsOnLight = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            PlayerIsOnLight = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        movementChar = GameObject.FindObjectOfType<MovementChar>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ticks = " + ticks);

        YouDiedPosX = movementChar.transform.position.x;
        YouDiedPosY = movementChar.transform.position.y;

        if (PlayerIsOnLight)
        {
            StartCoroutine(DamagePerTick());
        }

        if(ticks > 4 && PlayerIsDead == false)
        {
            StartCoroutine(YouDiedScene());
            ticks = 0;
        }

    }

    

    public IEnumerator DamagePerTick()
    {
        
        
        yield return new WaitForSeconds(0.20f);
        ticks ++;
        
    }

    public IEnumerator YouDiedScene()
    {
        movementChar.transform.position = new Vector3(-11.84f, -15.52f, -2);
        yield return new WaitForSeconds(0.1f);
        GameObject YouDied = Instantiate(youDied, new Vector3(YouDiedPosX, YouDiedPosY, -3), Quaternion.identity);
        YouDied.name = "YouDied";
        movementChar.AbleToMove = false;
        PlayerIsDead = true;

        yield return new WaitForSeconds(3);

        

        Destroy(GameObject.Find("YouDied"));
        movementChar.AbleToMove = true;
        
        
        StartCoroutine(CheckIfDead());
        ticks = 0;
    }

    public IEnumerator CheckIfDead()
    {
        yield return new WaitForSeconds(1);
        PlayerIsDead = false;
    }
  
}
