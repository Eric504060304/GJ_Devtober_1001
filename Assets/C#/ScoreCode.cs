using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour
{
    //だ计把计

    public static int Score;

    //ゅUI

    private void Start()
    {
        Score = 0;
    }

    public Text ShowScore;

    void Update()

    {

        //琵UIゅ籔だ计˙

        ShowScore.text = "Killed: "+ Score.ToString();
        

    }
    
}
