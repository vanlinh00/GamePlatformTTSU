using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public Transform daibangTranform;
    void Start()
    {
        if (Vector3.Distance(gameObject.transform.position, daibangTranform.position) <= 6)
        {
            Debug.LogError(" da ban dai bang");
            //transform.position = Vector3.Lerp(gameObject.transform.position, daibangTranform.position, speed);
            transform.Translate((transform.position - daibangTranform.position) * speed * Time.deltaTime*-1);
        }
        else { rb.velocity = transform.right * speed; }
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
