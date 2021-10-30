using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouEscape : MonoBehaviour
{
    [Header("經過的時間")]
    private int Time = 10;
    

    private void Update()
    {
        
    }



    public void ToMenu()
    {
        Application.LoadLevel("Menu");
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
    

    public void exitGame()
    {
        Application.Quit();
    }
}
