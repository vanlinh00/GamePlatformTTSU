using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	// Start is called before the first frame update

	public Animator animator;

	public Rigidbody2D rb2d;


	// Sprite  này thì từng con qoái lại khác nhau
	public SpriteRenderer render;

	public Transform ParTrs;

	public float speed;

	public float[] LimitX;
	// cá quan trong nhât để là 1 nhân vậy hay bot                     1
	public enum EnemyState
	{
		idle,
		run,
		turn,
		attack,
		hit,
		die
	}

	public EnemyState enemyState;

	protected virtual void DoStart()
	{
		if (speed > 0)
		{
			//  lật hình vẽ Flips the sprite on the X axis.
			render.flipX = true;
		}
		else
		{
			if (speed < 0)
			{
				render.flipX = false;
			}
		}
		if (ParTrs == null)
		{
			ParTrs = transform;
		}
	}

	// Update is called once per frame
	protected virtual void DoUpdate()
	{
		move();
	}

	protected virtual void move()
	{
		// nếu bức ảnh hiện thị
		if (render.isVisible)
		{
			// enemy đang ở trạng thái run
			if (enemyState == EnemyState.run)
			{
				ParTrs.position += ParTrs.right * speed * Time.smoothDeltaTime;

				if (ParTrs.position.x < LimitX[0])
				{
					Debug.LogError("// Vertoc3.right di chuyển object sang phải   ");
					// Vertoc3.right di chuyển object sang phải                                2
					speed = -speed;
				}
                else
                {
					if(ParTrs.position.x>LimitX[1])
                    {
						speed = -speed;
					}						
                }
			}
		}

	//	if (LimitX.Length == 2 && enemyState != EnemyState.die)
	//	{
	//		// Clamp gới hạn giá trị cho x 
	//		// gán Vector3= vector3 . thay đổi x còn y,z dữ nguyên                           3
	//		ParTrs.position = new Vector3(Mathf.Clamp(ParTrs.position.x, LimitX[0], LimitX[1]), ParTrs.position.y, ParTrs.position.z);
	//		/*A__________________________B*/
	//		// nếu nó đã di chuyển tới điểm A rồi thì
	//		if (ParTrs.position.x <= LimitX[0] && speed < 0)
	//		{
	//			StartTurn();
	//		}
	//		else
	//		{
	//			if (ParTrs.position.x >= LimitX[1] && speed > 0)
	//			{
	//				StartTurn();
	//			}
	//		}
	//	}
	//}
	//public virtual void StartTurn()
	//{
	//	if (enemyState != EnemyState.die)
	//	{
	//		// gán được trạng thái turn là xoay
	//		enemyState = EnemyState.turn;
	//	//	animator.Play("Turn", 0, 0);
	//		speed = -speed;           // bước này quyết định left of rigt  ParTrs.position += ParTrs.right * speed * Time.smoothDeltaTime; 
	//		if (speed > 0)
	//		{
	//			render.flipX = true;          // lật hình vẽ
	//		}
	//		else
	//		{
	//			if (speed < 0)
	//			{
	//				render.flipX = false;
	//			}
	//		}
	//	}
	}

}
