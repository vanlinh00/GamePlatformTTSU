using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController :MovePlayerControler
{
    // Start is called before the first frame update
    int heart = 5;
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
        //     Destroy(gameObject);

        if (collision.gameObject.tag.Equals("bullet"))
        {
            heart--;
            if(heart==0)
            {
                Destroy(gameObject);
            }    
        }
    }
 
}
