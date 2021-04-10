using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Scene1Data
{
    public bool RedKeyIsPickedUp;
    public bool YellowKeyIsPickedUp;

    public Scene1Data (Scene1 scene1)
    {
        RedKeyIsPickedUp = Scene1.RedKeyIsPickedUp;
        YellowKeyIsPickedUp = Scene1.YellowKeyIsPickedUp;
    }
}
