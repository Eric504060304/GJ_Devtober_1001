using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("���쪫��ĪG")]
    public GameObject hitEffect;
    public Rigidbody2D rb;
    public int damage = 50;

    

    void OnCollisionEnter2D(Collision2D hitInfo)
    {

        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject);
    
        
    }
}
