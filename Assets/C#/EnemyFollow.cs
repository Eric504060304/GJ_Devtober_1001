using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;

    private Transform playerPos;
    
    void Awake()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, playerPos.position) > 0.3f)
        {
            MoveTowardsPlayer();
            RotateTowardsPlayer();
        }
    }

    private void MoveTowardsPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    private void RotateTowardsPlayer()
    {
        var offset = 90f;
        Vector2 direction = playerPos.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.back * (angle + offset));

    }
}
