using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChar : MonoBehaviour
{
    
    //this bool is for the ability to move the char
    public bool AbleToMove = true;
    public float SpeedGameChar = 4f;

    // called once every frame
    void FixedUpdate()
    {
        
        if(AbleToMove == true)
        {
            //if W is pressed GameChar goes up
            if(Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
            }

            //if S is pressed GameChar goes down
            if(Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(0, SpeedGameChar, 0) * Time.deltaTime;
            }

            //if D is pressed GameChar goes to the Left
            if(Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
            }

            //if A is pressed GameChar goes to the right
            if(Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(SpeedGameChar, 0, 0) * Time.deltaTime;
            }
        }
        
    }
    


}
