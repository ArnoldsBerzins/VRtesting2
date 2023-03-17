using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    float currentTime;
    public Text currentTimeText;

    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = "Time Elapsed: " + time.ToString(@"mm\mss\s");
    }
}
