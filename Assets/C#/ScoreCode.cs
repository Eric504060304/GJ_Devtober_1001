using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour
{
    public static int Score;

    public Text ShowScore;

    private void Start()
    {
        Score = 0;
    }

    private void Update()
    {
        ShowScore.text ="Killed: "+ Score.ToString();
        PlayerWintheGame();
    }
    void PlayerWintheGame()
    {
        if (Score == 30)
        {
            Application.LoadLevel("YouEscape");
        }
    }
    

}
