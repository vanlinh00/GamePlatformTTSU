using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2Controller : Enemy
{
    // Start is called before the first frame update
    public GameObject boom;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        base.DoUpdate();
        GameObject boomdie = Instantiate(boom, transform.position, Quaternion.identity) as GameObject;

    }
}
