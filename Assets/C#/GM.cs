using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    [Header("���a��l��q")]
    public float TotalPlayerHP;
    [Header("���a���˦�q")]
    public float HurtPlayerHP;
    //�{�����p�⪱�a����q
    float TotalScriptHp;
    [Header("���a��q��")]
    public Image PlayerHPBar;

    
    

    // Start is called before the first frame update
    void Start()
    {

        //�{�������a����q
        TotalScriptHp = TotalPlayerHP;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void HurtPlayer()
    {
        //�ثe���a�{��������q=���a�{��������q-�ˮ`�q
        //TotalScriptHP = TotalScriptHP-HurtPlayerHP
        TotalScriptHp -= HurtPlayerHP;
        PlayerHPBar.fillAmount = TotalScriptHp / TotalPlayerHP;

        if (TotalScriptHp <= 0)
        {
            //�����Gameover
            Application.LoadLevel("GameOver");
        }
    }
}