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

            //�ĤH�l�u���쪱�a�H��A�������W�R�W��GM������A���GM�}���éI�sHurtPlayer function
            GameObject.Find("GM").GetComponent<GM>().HurtPlayer();
            Destroy(gameObject);
            
        }
    }
   
   
}
