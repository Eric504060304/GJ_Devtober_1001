using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject death;

    public int damage = 50;

    public AudioSource deathSound;
    


    public void TakeDamage(int damage)
    {

        health -= damage;
        if (health <= 0)
        {
            Die();
            deathSound.Play();
            ScoreCode.Score = ScoreCode.Score + 1;
        }
    }
    void Die()
    {
        
        Instantiate(death, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            //敵人子彈打到玩家以後，找到場景上命名為GM的物件，找到GM腳本並呼叫HurtPlayer function
            GameObject.Find("GM").GetComponent<GM>().HurtPlayer();
            Destroy(gameObject);
            
        }
    }
   
   
}
