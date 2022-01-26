using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private float currentTime = 0f;
    private bool timerStart = false;
    public float highScore = 0;
    public Text currentTimeText;
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerStart) {
            currentTime += Time.deltaTime;
            UpdateTimerComponent();
            SaveHighScore(currentTime);
        }
    }

    void UpdateTimerComponent()
    {
        currentTimeText.text = ToDigitalClockStringFormat(currentTime);
    }

    public void StartTimer()
    {
        timerStart = true;
    }

    public void StopTimer()
    {
        timerStart = false;
        currentTime = 0f;
        UpdateTimerComponent();
    }

    void SaveHighScore(float timeInSeconds)
    {
        if (timeInSeconds > highScore) {
            highScore = timeInSeconds;
            highScoreText.text = ToDigitalClockStringFormat(highScore);
        }
    }

    string ToDigitalClockStringFormat(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds /  60f);
        int seconds = Mathf.FloorToInt(timeInSeconds - minutes * 60);
        int hundredthOfASeconds = Mathf.FloorToInt((timeInSeconds - seconds) * 100);
        return string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, hundredthOfASeconds);
    }
}
