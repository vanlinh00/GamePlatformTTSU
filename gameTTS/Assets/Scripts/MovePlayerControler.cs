using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerControler : MonoBehaviour
{
    public Animator AnimatorObject;
    private Transform target;
    void Start()
    {

    }

    // Update is called once per frame
   protected void Update()
    {
        target = PlayerController.Instance.gettranformplayer();
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance <= 8)
        {
            AnimatorObject.SetBool("run", true);
            transform.Translate((transform.position - target.position) * 2f * Time.deltaTime * -1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("bullet"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag.Equals("Player"))
        {
            PlayerController.Instance.subtractHeart();
        }
    }
}
