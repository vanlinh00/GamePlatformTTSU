using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlController :MovePlayerControler
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag.Equals("Player"))
        {
           
        }
    }
}
