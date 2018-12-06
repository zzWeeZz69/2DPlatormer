using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class playermovement : MonoBehaviour
{
    [Range(0, 20f)]
    public float movespeed;
    public float jumpHeight;
    public groundcheck groundcheck;
    public float horizontalMove;

    [Header("Animator")]
    [Space]

    public Animator Anim;
    public AudioSource Sound;

    [Header("some other variables")]
    [Space]

    public bool Faceright;

    [Header("Dash")]
    [Space]

    [Range(0, 80f)]
    public float DashSpeed;
    private float DashTime;
    public float StartDashTime;
    private int Diracton;
    public GameObject DashEffect;

    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        Faceright = true;
        rbody = GetComponent<Rigidbody2D>();
        DashTime = StartDashTime;

    }

    // Update is called once per frame

    void Update()
    {
        

        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movespeed, rbody.velocity.y);

        Anim.SetFloat("Speed", Mathf.Abs(rbody.velocity.x));

        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }



        if (Input.GetKeyDown(KeyCode.Space) && groundcheck.touches > 1)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            Sound.Play();
        }

       if(Diracton == 0)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Diracton = 1;
                Instantiate(DashEffect, transform.position, Quaternion.identity);
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                Diracton = 2;
                Instantiate(DashEffect, transform.position, Quaternion.identity);
            }
        }
        else
        {
            if(DashTime <= 0)
            {
                Diracton = 0;
                DashTime = StartDashTime;
                rbody.velocity = Vector2.zero;
            }
            else
            {
                DashTime -= Time.deltaTime;
                if (Diracton == 1)
                {
                    rbody.velocity = Vector2.left * DashSpeed;
                }
                else if(Diracton == 2)
                {
                    rbody.velocity = Vector2.right * DashSpeed;
                }
            }
        }

    }
    
}
