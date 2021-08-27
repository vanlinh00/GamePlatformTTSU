using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3Beecontroller : MonoBehaviour
{ // Start is called before the first frame update
    private Transform target;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        target = PlayerController.Instance.gettranformplayer();
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= 6)
        {
            transform.Translate((transform.position - target.position) * 2f * Time.deltaTime*-1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.LogError("ban da cham vao bee");
    }
}
