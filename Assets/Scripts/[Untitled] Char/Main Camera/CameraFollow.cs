using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;
    public static bool CamerIsFollowing = true;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (CamerIsFollowing)
        {
            //we store currnet camera position in var temp
            Vector3 temp = transform.position;

            temp.x = playerTransform.position.x;
            temp.y = playerTransform.position.y;

            // we set back the camera's temp position to the camera current position
            transform.position = temp;
        }
    }
}
