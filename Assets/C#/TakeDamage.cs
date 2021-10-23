using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    
    public int maxhp;
    public GameObject target;
    private Rigidbody2D rb2d;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Bullet")
        {
            maxhp = maxhp - 1;
        }
        if(maxhp == 0)
        {
            killed();
        }
    }
    private void killed()
    {
        Destroy(gameObject);
    }
}
