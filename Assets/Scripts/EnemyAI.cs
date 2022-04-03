using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            rb2d.velocity = Vector2.zero;
            Destroy(gameObject, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2d.position.x < 0)
            rb2d.AddForce(new Vector2(1, 0));
        if (rb2d.position.x > 0)
            rb2d.AddForce(new Vector2(-1, 0));
        if (rb2d.position.y < 0)
            rb2d.AddForce(new Vector2(0, 1));
        if (rb2d.position.y > 0)
            rb2d.AddForce(new Vector2(0, -1));
    }
}
