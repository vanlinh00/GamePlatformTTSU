using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("enemy"))
        {
            Destroy(gameObject);
        }
        //Destroy(gameObject);
    }
}
