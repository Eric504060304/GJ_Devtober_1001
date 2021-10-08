using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class Playermovement : MonoBehaviour
{



    private Rigidbody2D rig;
    private AudioSource aud;
    private Animator ani;




    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();

    }
    


    void Update()
    {

    }
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");//���k����
        float y = Input.GetAxisRaw("Vertical");//�W�U����

        //Reset MoveDelta
        moveDelta = new Vector3(x, y, 0);

        //Swap sprite direction, wether you're going right or left
        if (moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        //make this thing move
        transform.Translate(moveDelta * Time.deltaTime*10f);
    }
}
