using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text countdownText;
    public Text statTimer;
    float totalTime;
    float speed = 1;

    public float remainingTime;
    public float waveTime;

    // Start is called before the first frame update
    void Start()
    {
        remainingTime = waveTime;
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch();
        countdown();
    }

    void stopwatch()
    {
        totalTime += Time.deltaTime * speed;
        string minutes = Mathf.Floor((totalTime % 3600) / 60).ToString("00");
        string seconds = Mathf.Floor(totalTime % 60).ToString("00");
        timerText.text = "Time: " + minutes + ":" + seconds;
        statTimer.text = "Time Taken: " + minutes + ":" + seconds;
        if (remainingTime <= 0)
        {
            totalTime -= Time.deltaTime * speed;
        }
    }

    public void countdown()
    {
        remainingTime -= Time.deltaTime * speed;
        countdownText.text = "Time Left: " + remainingTime.ToString("0");
        if (remainingTime <= 0)
        {
            remainingTime = 0;
        }
    }
}