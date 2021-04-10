using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownNote : MonoBehaviour
{
    bool GoToTop = true;
    bool GoToBottom = false;

    // Update is called once per frame
    void Update()
    {
        if (GoToTop)
        {
            Up();
        }

        if (GoToBottom)
        {
            Down();
        }

    }

    void Up()
    {
        transform.position += new Vector3(0, 0.1f, 0) * Time.deltaTime;
        if(transform.position.y > 1)
        {
            GoToTop = false;
            GoToBottom = true;
        }
    }
    void Down()
    {
        transform.position -= new Vector3(0, 0.1f, 0) * Time.deltaTime;
        if (transform.position.y < -1.3f)
        {
            GoToTop = true;
            GoToBottom = false;
        }
    }
}
