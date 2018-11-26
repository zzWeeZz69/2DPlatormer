using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHorizontalmoment : MonoBehaviour
{
    [Header("Move Speed")]
    [Space]
    public float moveSpeed = 2f;
    public float Raylegth;
    public GameObject Walls;


    [Header("turn Bool")]
    [Space]
    public bool isleft = true;


    
    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Move();
    }



    void Move()
    {

        isleft = !isleft;

        if (isleft == true)
        {
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
