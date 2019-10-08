using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public float timeLeft = 600.00f;
    public Text countDown;
    public Text scoreText;
    public Text winText;
    public int score;

    void Start()
    {
        winText.text = "";
        SetScoreText();
        score = 0;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeLeft / 60F);
        int seconds = Mathf.FloorToInt(timeLeft % 60F);
        int milliseconds = Mathf.FloorToInt((timeLeft * 100F) % 100F);
        countDown.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Island Other"))
        {
            score = score++;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
