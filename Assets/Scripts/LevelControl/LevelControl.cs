﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DoorToOtherLevel"))
        {
            
            Debug.Log("Je gaat de deur in");
            SceneManager.LoadScene("Test");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}