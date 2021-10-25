using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [Header("經過的時間")]
    private int Time = 10;

    public Text time_UI;

    private void Start()
    {
        InvokeRepeating("timer", 1, 1);
    }


    public void Restartgame()
    {
        Application.LoadLevel("Game");
    }

    private IEnumerator TenSecondExitGame()
    {

        for (int i = 1; i < 10; i++)
        {
            Time += 1;
            yield return new WaitForSeconds(1f);
            Application.Quit();
        }
    }
    public void restartGame()
    {
        Application.LoadLevel("Game");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    void timer()
    {
        Time -= 1;
        time_UI.text = Time + "";
        if (Time == 0)
        {
            CancelInvoke("timer");
        }
    }


}
