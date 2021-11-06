using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathVFX;

    public int damage = 50;

   

    


    private void Start()
    {
       
    }

    public void TakeDamage(int damage)
    {
        
         
         health -= damage;

        if (health <= 0)
        {
            
            Die();
            
            ScoreCode.Score = ScoreCode.Score + 1;
            if (ScoreCode.Score == 30)
            {
                Application.LoadLevel("YouEscape");
            }
        }
        
    }
    void Die()
    {
        
        Instantiate(deathVFX, transform.position, Quaternion.identity);
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
