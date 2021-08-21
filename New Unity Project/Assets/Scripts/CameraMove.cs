using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    
    //// Start is called before the first frame update
    //public GameObject player;
    //void Start()
    //{
    //    player = GameObject.FindGameObjectWithTag("Player");

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    //   transform.position = player.transform.position;
    //    gameObject.transform.position.z = 3;
    //}

    public GameObject player;
    private Vector3 offset;
    private Vector3 newtrans;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset.x = transform.position.x - player.transform.position.x;
        offset.y = transform.position.y - player.transform.position.y;
        newtrans = transform.position;
        //not taking y as we wont update y position. 

    }
    void LateUpdate()
    {
        newtrans.x = player.transform.position.x + offset.x;
        newtrans.y = player.transform.position.y + offset.y;
        transform.position = newtrans;
    }
}
