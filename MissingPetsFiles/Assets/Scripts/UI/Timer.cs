using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    int timeLeft = 30;
    bool timeRunning = true;
    float time;

    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {

        
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
        timerText.text = timeLeft.ToString();
    }

    internal void addTime(int t)
    {
        timeLeft += t;
    }

    internal void setTimeRunning(bool b)
    {
        timeRunning = b;
    }
}
