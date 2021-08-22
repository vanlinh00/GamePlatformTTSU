using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public static PlayerController Instance;
    private Animator player;
    Rigidbody2D rb2d;
    public float speed;
    public float vjump;
  public  int heard = 3, coin = 0;
    public enum PlayerState
    {
        idle,
        run,
        jumb,
        die,
    }
    public PlayerState playerState;
    private void Awake()
    {
        Instance = this;
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        player = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if((Input.GetKey(KeyCode.A)))
        {
           
            player.SetBool("Run", true);
            Move(-1);
        }
        if ((Input.GetKey(KeyCode.D)))
        {
           
            player.SetBool("Run",true);
            Move(1);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            player.SetBool("Jump", true);
            Jumb(1);
        }
        else
        {
            player.SetBool("idle", true);
        }

        BulletControler.Instance.target = transform.position;
    }
    void Move(int v)
    {
        rb2d.velocity = new Vector2(v*speed, rb2d.velocity.y);
    }
    void Jumb(int J)
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, J * vjump );
    }  
    void AddCoin(int coin)
    {

    }
    void Die()
    {
        if(playerState==PlayerState.die)
        {
          /// do somthing
        }    
    }
   public void subtractHeart()
    {
        heard--;
        UiController.Instance.Hheart(heard);
    }
   
}
