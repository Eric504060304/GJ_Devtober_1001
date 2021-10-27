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
            
            //�ľ��l�u���쪱�a�H��A�������W�R�W��GM������A���GM�}���éI�sHurtPlayer function
            GameObject.Find("GM").GetComponent<GM>().HurtPlayer();
            //�ľ��l�u�n����
            Destroy(gameObject);
        }
    }
}
