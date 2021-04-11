using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChar : MonoBehaviour
{
    
    //this bool is for the ability to move the char
    public bool AbleToMove = true;
    public static float SpeedGameChar = 4f;

    public bool GameCharHasNoKey = true;
    public bool GameCharHasBlueKey = false;
    public bool GameCharHasGreenKey = false;
    public bool GameCharHasYellowKey = false;
    public bool GameCharHasRedKey = false;
    public bool GameCharHasPinkKey = false;

    public bool GameCharHasNoKeyHat = false;
    public bool GameCharHasBlueKeyHat = false;
    public bool GameCharHasGreenKeyHat = false;
    public bool GameCharHasYellowKeyHat = false;
    public bool GameCharHasRedKeyHat = false;
    public bool GameCharHasPinkKeyHat = false;

    public GameObject Up;
    public GameObject UpKey;
    public GameObject UpHat;
    public GameObject UpHatKey;


    public GameObject Down;
    public GameObject DownBlueKey;
    public GameObject DownGreenKey;
    public GameObject DownPinkKey;
    public GameObject DownRedKey;
    public GameObject DownYellowKey;

    public GameObject DownHat;
    public GameObject DownBlueKeyHat;
    public GameObject DownGreenKeyHat;
    public GameObject DownPinkKeyHat;
    public GameObject DownRedKeyHat;
    public GameObject DownYellowKeyHat;

    public GameObject Right;

    public GameObject Left;

    // called once every frame
    void FixedUpdate()
    {
        
        if(AbleToMove)
        {
            if (GameCharHasNoKey)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                    Up.SetActive(true);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(false);
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;

                    Up.SetActive(false);
                    Down.SetActive(true);
                    Right.SetActive(false);
                    Left.SetActive(false);
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;

                    
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(true);
                    Left.SetActive(false);
                    
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;

                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }

            if (GameCharHasBlueKey)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }

            if (GameCharHasGreenKey)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }

            if (GameCharHasYellowKey)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }

            if (GameCharHasRedKey)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }

            if (GameCharHasPinkKey)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }

            if (GameCharHasNoKeyHat)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }

            if (GameCharHasBlueKeyHat)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }

            if (GameCharHasGreenKeyHat)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }

            if (GameCharHasYellowKeyHat)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }

            if (GameCharHasRedKeyHat)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }

            if (GameCharHasPinkKeyHat)
            {
                //if W is pressed GameChar goes up
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if S is pressed GameChar goes down
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
                }

                //if D is pressed GameChar goes to the Left
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                }

                //if A is pressed GameChar goes to the right
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
                    Up.SetActive(false);
                    Down.SetActive(false);
                    Right.SetActive(false);
                    Left.SetActive(true);
                }
            }


            
        }
        
    }
    


}
