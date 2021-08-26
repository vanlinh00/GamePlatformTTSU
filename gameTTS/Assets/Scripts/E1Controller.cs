using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1Controller: Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        base.DoUpdate();
        if (enemyState == EnemyState.die)
        {
            transform.up = rb2d.velocity;
        }
    }
    protected override void DoUpdate()
    {
       
       
    }
   

}
