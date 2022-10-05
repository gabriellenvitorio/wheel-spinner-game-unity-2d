using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public AudioSource audioSourceBgMusic;
    public AudioClip bgMusic;

    // Start is called before the first frame update
    void Start()
    {
        AudioClip backgroundMusic = bgMusic;
        audioSourceBgMusic.clip = backgroundMusic;
        audioSourceBgMusic.loop = true;
        audioSourceBgMusic.Play();
    }

    
}
