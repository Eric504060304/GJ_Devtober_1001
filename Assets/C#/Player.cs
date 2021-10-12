using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{



    public Rigidbody2D rb;
    private AudioSource aud;
    private Animator ani;



    
    //private BoxCollider2D boxCollider;
    public float moveSpeed = 5f;
    Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        #region 移動的另外一種寫法
        /* 移動寫法
        //Reset MoveDelta
        //moveDelta = new Vector3(x, y, 0);
        //Swap sprite direction, wether you're going right or left
        if (moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);
        //Make sure we can move in this direction, by castig a box tthere first, if the box returns null, we're free to move 
        hit = Physics2D.BoxCast
            (transform.position, boxCollider.size, 0,
            new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime),
            LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //Make this thing move!
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        }

        hit = Physics2D.BoxCast
            (transform.position, boxCollider.size, 0,
            new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime),
            LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //Make this thing move!
            transform.Translate(moveDelta.x, 0 * Time.deltaTime, 0, 0);
        }
        */
        #endregion

    }
}
