using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHorizontalmoment : MonoBehaviour
{
    [Header("Move Speed")]
    [Space]
    public float moveSpeed = 2f;
    public float Raylegth;
    


    [Header("turn Bool")]
    [Space]
    public bool isleft = true;


    
    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        // hämmtar componenten Rigidbody2D
        rbody = GetComponent<Rigidbody2D>();
        Move();

    }
    // kör en "Void" när något träffar Collidern
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Move();
    }



    void Move()
    {

        isleft = !isleft;
        // säger om den kollar till vänster gå åt vänster anas gå höger
        if (isleft == true)
        {
            // får "enemy" att röra sig till vänster
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);

            // skalar enemy så att den kollar åt vänster
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            // får "enemy" att röra sig till höger
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);

            // skallar om enemy så att den kollar åt höger
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
