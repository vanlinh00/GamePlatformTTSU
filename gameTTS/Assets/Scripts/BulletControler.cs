using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    // Start is called before the first frame update
    public static BulletControler Instance;
    public Transform target;
    public float MoveSpeed;
    void Start()
    {
        Instance = this;
 
         target=   PlayerController.Instance.gettranformplayer();
        
    }
    

    // Update is called once per frame
    void Update()
    {

        transform.Translate((transform.position - target.position) * MoveSpeed * Time.deltaTime * -1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
        GameController.Instance.LoadSenceAgain();
    }
}
