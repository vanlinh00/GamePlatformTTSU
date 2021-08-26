using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2Controller : Enemy
{
    // Start is called before the first frame update
    public GameObject boom;
    public GameObject player;
    public float Timephan=4f;
    float timedau = 0f;
    int a = 3;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
       
    }

    // Update is called once per frame
    void Update()
    {
        base.DoUpdate();
       
      if(a==3)
        {
            timedau = Time.time;
            a = 2;
        }
     
        float distance = Vector3.Distance(player.transform.position,transform.position);
        if (distance <= 4&&Time.time>=timedau+4f)
        {
            a = 3;
            GameObject boomdie = Instantiate(boom, transform.position, Quaternion.identity) as GameObject;
            Destroy(boomdie, 4f);
        }
    }

}
