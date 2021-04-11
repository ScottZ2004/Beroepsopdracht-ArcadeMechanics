using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        if(StartButton.StartIsPressed == true)
        {
            
            SceneManager.LoadScene("Basement");
            StartButton.StartIsPressed = false;
            
        }
    }
}
