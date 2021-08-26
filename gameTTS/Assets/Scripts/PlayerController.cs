using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public static PlayerController Instance;
    private Animator Aniplayer;
    Rigidbody2D rb2d;
    public float speed;
    public float jump;
    public  int heard = 3, coin = 0;
    bool isGround;
    public Joystick joystick;
    float movement;
    public bool isjump;
    public GameObject Bullet;
    public Transform firepoint;
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
        isGround = false;
        Instance = this;
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Aniplayer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if((Input.GetKey(KeyCode.A)))
        // {

        //     player.SetBool("Run", true);
        //     Move(-1);
        // }
        // if ((Input.GetKey(KeyCode.D)))
        // {

        //     player.SetBool("Run",true);
        //     Move(1);
        // }
        // if(Input.GetKey(KeyCode.Space)&&isGround==true)
        // {
        //     Debug.LogError("isGround"+isGround);
        //     player.SetBool("Jump", true);
        //     Jumb(1);
        //     isGround = false;
        // }
        // else
        // {
        //     player.SetBool("Idle", true);
        // }



        //  BulletControler.Instance.target = transform.position;
#if UNITY_ANDROID || UNITY_IOS

        movement = joystick.Horizontal;
#else
 
    movement = Input.GetAxis("Horizontal");
    
        if(Input.GetButtonDown("Jump"))
        {
            Fjump(jump);
        }    
#endif
        MovePlayer(movement);
        if(isjump)
        Fjump(jump);

    }

      void MovePlayer(float movement)
    {

        if (!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
        if (movement<0)
        {
            Aniplayer.SetBool("Run", true);
            
        }

        if (movement > 0)
        {
            Aniplayer.SetBool("Run", true);
        }
        if (movement == 0)
        {
            Aniplayer.SetBool("Run", false);
            Aniplayer.SetBool("Jump", false);
        }
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

    } 
    public void Fjump(float jump1)
    {
        if (Mathf.Abs(rb2d.velocity.y) < 0.001f)
        {
            Aniplayer.SetBool("Jump", true);
            rb2d.AddForce(new Vector2(0, jump1), ForceMode2D.Impulse);
        }
        isjump = false;
    } 
    public void Shoot()
    {
        GameObject bullet1 = Instantiate(Bullet,firepoint.position, Quaternion.identity) as GameObject;

    }
     
//void Move(int v)
//{
//    rb2d.velocity = new Vector2(v*speed*Time.deltaTime, rb2d.velocity.y);
//}
//void Jumb(int J)
//{
//    rb2d.velocity = new Vector2(rb2d.velocity.x, J * vjump );
//}  
//void AddCoin(int coin)
//{

//}
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
    public void OnCollisionEnter2D(Collision2D collision)
    {
       
        if(collision.gameObject.tag.Equals("Ground"))
        {
            isGround = true;
           transform.SetParent(null);
        }
        if(collision.gameObject.tag.Equals("waterAnimation"))
        {
            GameController.Instance.LoadSenceAgain();
        }    
      
    }
  

}
