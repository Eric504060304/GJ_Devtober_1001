using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject death;



    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
            ScoreCode.Score = ScoreCode.Score + 1;
        }
    }
    void Die()
    {
        Instantiate(death, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (gameObject.tag == "Enemy" && hit.GetComponent<Collider2D>().tag == "Player")
        {
            
            //敵機子彈打到玩家以後，找到場景上命名為GM的物件，找到GM腳本並呼叫HurtPlayer function
            GameObject.Find("GM").GetComponent<GM>().HurtPlayer();
            //敵機子彈要消失
            Destroy(gameObject);
        }
    }
}
