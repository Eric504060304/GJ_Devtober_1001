using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    [Header("玩家初始血量")]
    public float TotalPlayerHP;
    [Header("玩家受傷血量")]
    public float HurtPlayerHP;
    //程式中計算玩家的血量
    float TotalScriptHp;
    [Header("玩家血量條")]
    public Image PlayerHPBar;

    
    

    // Start is called before the first frame update
    void Start()
    {

        //程式中玩家的血量
        TotalScriptHp = TotalPlayerHP;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void HurtPlayer()
    {
        //目前玩家程式中的血量=玩家程式中的血量-傷害量
        //TotalScriptHP = TotalScriptHP-HurtPlayerHP
        TotalScriptHp -= HurtPlayerHP;
        PlayerHPBar.fillAmount = TotalScriptHp / TotalPlayerHP;

        if (TotalScriptHp <= 0)
        {
            //跳轉至Gameover
            Application.LoadLevel("GameOver");
        }
    }
}