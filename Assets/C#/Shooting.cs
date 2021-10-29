using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BulletPrefab;
    public float BulletForce = 20f;
    public AudioSource aud;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
            
        }
    }
    void Shoot()
    {
        GameObject Bullect = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rig =  Bullect.GetComponent<Rigidbody2D>();
        rig.AddForce(firePoint.up * BulletForce, ForceMode2D.Impulse);
        aud.Play();
    }
}
