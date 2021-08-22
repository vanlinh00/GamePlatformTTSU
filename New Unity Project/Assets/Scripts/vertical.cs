using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical : MonoBehaviour
{
    // Start is called before the first frame update
    public float Movespeed;
    public float[] LimitY;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
       
    }
    void Move()
    {
        transform.position += transform.up * Movespeed*Time.smoothDeltaTime;
        if(LimitY.Length==2&&transform.position.y<LimitY[0])
        {
            Movespeed = -Movespeed;
        }
        else
        {
            if(LimitY.Length==2&&transform.position.y>LimitY[1])
            {
                Movespeed = -Movespeed;
            }    
        }
    }
   
}
