using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    public Rigidbody2D rig;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    private void Start()
    {
        Physics2D.IgnoreLayerCollision(6, 9);
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
        rig.MovePosition(rig.position + movement * speed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - rig.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        rig.rotation = angle;
    }
}
