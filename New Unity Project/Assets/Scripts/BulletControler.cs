using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    // Start is called before the first frame update
    public static BulletControler Instance;
    public Vector3 target;
    public float MoveSpeed;
    void Start()
    {
        Instance = this;
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate((transform.position - target) * MoveSpeed * Time.deltaTime*-1);
        
    }
}
