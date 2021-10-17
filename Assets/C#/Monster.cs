using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float killednumber;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        if (killednumber == 25)
        {
            moveSpeed = 15f;
        }
        else if (killednumber == 50)
        {
            moveSpeed = 25f;
        }
        else  if (killednumber == 75)
        {
            moveSpeed = 30f;
        }
        else
        {
            
        }
                
               
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

        
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position +(direction* moveSpeed*Time.deltaTime));
    }
}
