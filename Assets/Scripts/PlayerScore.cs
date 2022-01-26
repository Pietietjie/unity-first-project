using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private float currentTime = 0f;
    private bool timerStart = false;
    public float highScore;
    public Text currentTimeText;
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("highScore");
        UpdateHighScoreUI();
        StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerStart) {
            currentTime += Time.deltaTime;
            UpdateTimerUI();
            UpdateHighScore(currentTime);
        }
    }

    void UpdateTimerUI()
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
        UpdateTimerUI();
        SaveHighScore();
    }

    void UpdateHighScore(float timeInSeconds)
    {
        if (timeInSeconds > highScore) {
            highScore = timeInSeconds;
            UpdateHighScoreUI();
        }
    }

    void UpdateHighScoreUI()
    {
        highScoreText.text = ToDigitalClockStringFormat(highScore);
    }

    void SaveHighScore()
    {
        PlayerPrefs.SetFloat("highScore", highScore);
        PlayerPrefs.Save();
    }

    string ToDigitalClockStringFormat(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds /  60f);
        int seconds = Mathf.FloorToInt(timeInSeconds - minutes * 60);
        int hundredthOfASeconds = Mathf.FloorToInt((timeInSeconds - seconds) * 100);
        return string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, hundredthOfASeconds);
    }
}
