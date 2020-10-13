 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{

    public float speed = 2f;
    private float movementX = 0f;
    public float jumpSpeed = 6f;
    private new Rigidbody2D rigidbody;
    private float g = -9.81f;
    public Transform groudCheckPoint;
    public float radius;
    public LayerMask groundLayer;
    private bool isTouchingGroung;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        isTouchingGroung = Physics2D.OverlapCircle(groudCheckPoint.position, radius, groundLayer);
        movementX = Input.GetAxis("Horizontal");
       


        if (movementX != 0)
        {
            rigidbody.velocity = new Vector2(movementX * speed, rigidbody.velocity.y);
        }

        Debug.Log(isTouchingGroung);
        if (Input.GetButtonDown("Jump") && isTouchingGroung)
        {
            
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpSpeed);
        }


       
        
    }
}
