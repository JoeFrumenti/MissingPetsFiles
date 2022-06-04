using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHandler : MonoBehaviour
{
    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    public void playMusic()
    {
        if(!audioData.isPlaying)
            audioData.Play();
    }

    public void stopMusic()
    {
        audioData.Stop();
    }
}
