using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip PickUpSound, OpenSound, CloseSound, ButtonPressedSound;
    static AudioSource audioSrc;

    
    void Start()
    {
        PickUpSound = Resources.Load<AudioClip>("Pickup");
        OpenSound = Resources.Load<AudioClip>("Open");
        CloseSound = Resources.Load<AudioClip>("Close");
        ButtonPressedSound = Resources.Load<AudioClip>("ButtonPressed");

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

            default:
                Debug.Log("No sound found");
                break;

        }
    }
}