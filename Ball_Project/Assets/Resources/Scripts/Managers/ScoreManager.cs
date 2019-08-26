using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : GenericSingleton<ScoreManager>
{
    public float score = 0;
    public float highScore = 0;
    public Text scoreText;

    public override void Awake()
    {
        base.Awake();
    }

    public void AddScore(float points)
    {
        score += points;
        checkHighScore();
        UpdateScoreText();
    }

    private void checkHighScore()
    {
        if (score > highScore)
            highScore = score;
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}
