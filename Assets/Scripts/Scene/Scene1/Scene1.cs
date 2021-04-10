using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1 : MonoBehaviour
{
    public static bool RedKeyIsPickedUp = false;
    public static bool YellowKeyIsPickedUp = false;
    
    public void SaveScene1()
    {
        SaveSystem.SaveScene1(this);
    }

    public void LoadScene1()
    {
        Scene1Data data = SaveSystem.LoadScene1();

        RedKeyIsPickedUp = data.RedKeyIsPickedUp;
        YellowKeyIsPickedUp = data.YellowKeyIsPickedUp;

        if (RedKeyIsPickedUp)
        {
            Destroy(GameObject.Find("RedKey"));
        }

        if (YellowKeyIsPickedUp)
        {
            Destroy(GameObject.Find("YellowKey"));
        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SaveScene1();
            Debug.Log("Scene1 Opgeslagen!!!!!");
        }
    }

    void Start()
    {
        LoadScene1();
    }
}
