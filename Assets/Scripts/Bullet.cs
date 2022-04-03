using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.up * speed;
       //Destroy(gameObject, 1);

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //if()
        Debug.Log(hitInfo.name);
        //Destroy(gameObject);
    }
}
