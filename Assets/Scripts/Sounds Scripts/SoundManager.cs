using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip PickUpSound, OpenSound, CloseSound, ButtonPressedSound, SwitchLever, UseCassete, BoomBoxMusic, DoorOpens, JailDoorOpens;
    static AudioSource audioSrc;

    
    void Start()
    {
        PickUpSound = Resources.Load<AudioClip>("Pickup");
        OpenSound = Resources.Load<AudioClip>("Open");
        CloseSound = Resources.Load<AudioClip>("Close");
        ButtonPressedSound = Resources.Load<AudioClip>("ButtonPressed");
        SwitchLever = Resources.Load<AudioClip>("LeverSwitch");
        BoomBoxMusic = Resources.Load<AudioClip>("BoomBoxMusic");
        UseCassete = Resources.Load<AudioClip>("CasseteUse");
        DoorOpens = Resources.Load<AudioClip>("DoorOpens");
        JailDoorOpens = Resources.Load<AudioClip>("JailDoorOpens");

        audioSrc = GetComponent<AudioSource>();
    }


    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Pickup":
                audioSrc.PlayOneShot(PickUpSound);
                break;

            case "Open":
                audioSrc.PlayOneShot(OpenSound);
                break;

            case "Close":
                audioSrc.PlayOneShot(CloseSound);
                break;

            case "ButtonPressed":
                audioSrc.PlayOneShot(ButtonPressedSound);
                break;

            case "SwitchLever":
                audioSrc.PlayOneShot(SwitchLever);
                break;

            case "BoomBoxMusic":
                audioSrc.PlayOneShot(BoomBoxMusic);
                break;

            case "UseCassete":
                audioSrc.PlayOneShot(UseCassete);
                break;

            case "DoorOpens":
                audioSrc.PlayOneShot(DoorOpens);
                break;

            case "JailDoorOpens":
                audioSrc.PlayOneShot(JailDoorOpens);
                break;

            default:
                Debug.Log("No sound found");
                break;

        }
    }
}