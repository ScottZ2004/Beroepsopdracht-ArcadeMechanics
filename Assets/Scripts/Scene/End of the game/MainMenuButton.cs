using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuButton : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("MainMenu");
    }
   
}
