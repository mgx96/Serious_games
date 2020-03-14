using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip playerWalking;
    static AudioSource audioSrc;

    void Start()
    {
        playerWalking = Resources.Load<AudioClip>("walk_sound 1");

        audioSrc = GetComponent<AudioSource>();
    }

  
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "walk_sound 1":
                audioSrc.PlayOneShot(playerWalking);
                break;
        }
    }
}
