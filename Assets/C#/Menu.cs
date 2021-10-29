using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button startbutton;
    public Button exitbutton;

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Startbutton()
    {

        Application.LoadLevel("Game");

    }
    public void ExitButton()
    {


        Application.Quit();

    }
}
