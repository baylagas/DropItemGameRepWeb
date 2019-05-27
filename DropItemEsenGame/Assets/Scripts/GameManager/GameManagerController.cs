using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerController : MonoBehaviour
{
    public int gameScore;
    public Text scoreText;

    private void Start()
    {
        gameScore = 0;
    }

    public void ModifyGameScore(int value)
    {
        gameScore = value;
    }

    public void SetScoreText()
    {
        scoreText.text = gameScore + "";
    }
}
