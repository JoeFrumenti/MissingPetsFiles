using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStarter : MonoBehaviour
{
   // Start is called before the first frame update
    void Start()
    {
        MusicHandler S = GameObject.Find("Music").GetComponent<MusicHandler>();
        S.playMusic();
        GameObject.FindWithTag("ScoreKeep").GetComponent<ScoreKeep>().ResetScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
