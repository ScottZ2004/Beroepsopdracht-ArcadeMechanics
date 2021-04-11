using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNotes : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(0.3f, 0.25f, 0) * Time.deltaTime;
        if(transform.position.x > 8)
        {
            Destroy(gameObject);
            BoomBox.BoomBoxIsPlaying = false;
        }
        
    }
}
