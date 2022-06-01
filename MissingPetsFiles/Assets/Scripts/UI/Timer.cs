using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    int timeLeft = 30;
    int timerCap = 50;
    bool timeRunning = true;
    float time;

    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 30;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeRunning)
            time+= Time.deltaTime;
        if(time >=1)
        {
            time = 0;
            timeLeft --;
        }
        if(timeLeft >= 0)
            timerText.text = timeLeft.ToString();
        else
            timerText.text = "0";
        if (timeLeft <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    internal void addTime(int t)
    {
        timeLeft += t;
        if(timeLeft > timerCap)
            timeLeft = timerCap;
    }

    internal void setTimeRunning(bool b)
    {
        timeRunning = b;
    }
}
