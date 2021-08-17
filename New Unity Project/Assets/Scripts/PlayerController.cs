using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator player;
    void Start()
    {
        player = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(true)
        {
            Debug.LogError("run");
            player.SetBool("Run", true);
        }    
    }
}
