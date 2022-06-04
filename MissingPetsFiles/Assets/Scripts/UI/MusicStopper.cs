using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStopper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MusicHandler S = GameObject.Find("Music").GetComponent<MusicHandler>();
        S.stopMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
