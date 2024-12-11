using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    public GameObject winCanvas;
    private float currentTime = 0f;

    public bool stopWatchActive = true;

    private void Update()
    {
        if (stopWatchActive)
        {
            currentTime += Time.deltaTime;
        }
        
        if (winCanvas.gameObject.activeSelf)
        {
            stopWatchActive = false;
            Pause();
        }
    }

    public void Pause()
    {
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timerText.text = string.Format("Time: " + time.Minutes.ToString() + ":" + time.Seconds.ToString());

    }

   
}

