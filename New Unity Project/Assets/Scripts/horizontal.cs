using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontal : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed= 0.3f;
    public float[] LimitX;
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
        transform.position += transform.right * speed * Time.smoothDeltaTime;
        if (LimitX.Length==2&&transform.position.x < LimitX[0])
        {
            speed = -speed;
        }
        else
        {
            if((LimitX.Length == 2&&transform.position.x > LimitX[1]))
          {
                speed = -speed;
            }
        }
    }    
}
