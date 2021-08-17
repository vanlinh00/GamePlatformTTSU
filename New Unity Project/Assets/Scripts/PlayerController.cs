using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator player;
    Rigidbody2D rb2d;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        player = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if((Input.GetKey(KeyCode.A)))
        {
           
            player.SetBool("Run", true);
            Move(3);
        }
        if ((Input.GetKey(KeyCode.D)))
        {
            
            player.SetBool("Run", false);
        }
    }
    void Move(int v)
    {
        rb2d.velocity = new Vector2(v, rb2d.velocity.y);
    }   
    
}
