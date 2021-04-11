using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasmachinePuzzel : MonoBehaviour
{
    public MovementChar movementChar;

    bool camerGoesDown = true;
    bool cameraGoesToLeft = false;

    public int CameraSpeed;

    void Start()
    {
        movementChar = GameObject.FindObjectOfType<MovementChar>();
    }
    public void PlayCutscene()
    {
        movementChar.AbleToMove = false;
        CameraFollow.CamerIsFollowing = false;
        if (camerGoesDown)
        {
            transform.position += new Vector3(0, -CameraSpeed, 0) * Time.deltaTime;
        }

        if (cameraGoesToLeft)
        {
            transform.position += new Vector3(-CameraSpeed, 0, 0) * Time.deltaTime;
        }

        if (transform.position.y < -14)
        {
            camerGoesDown = false;
            cameraGoesToLeft = true;
        }

        if (transform.position.x < -6)
        {
            cameraGoesToLeft = false;
            StartCoroutine(OpenJailDoor());
        }
    }

    IEnumerator OpenJailDoor()
    {
        yield return new WaitForSeconds(0.75f);

        Destroy(GameObject.Find("gevangenis deur links"));
        
        yield return new WaitForSeconds(0.7f);

        CameraFollow.CamerIsFollowing = true;
        movementChar.AbleToMove = true;
        InterectWithGameObject.washingMachinePuzzleSolved = true;
    }

}
