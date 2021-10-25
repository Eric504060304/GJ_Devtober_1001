using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int Time = 10;

    public Text time_UI;
    private void Start()
    {
        InvokeRepeating("timer", 1, 1);
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
