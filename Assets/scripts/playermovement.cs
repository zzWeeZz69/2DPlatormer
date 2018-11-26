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
    [Header("some other variables")]
    [Space]
    public bool Faceright;
    public GameObject Deatheffect;


    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        Faceright = true;
        rbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame

    void Update()
    {
        

        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movespeed, rbody.velocity.y);

        Anim.SetFloat("Speed", Mathf.Abs(rbody.velocity.x));
       


        if (Input.GetKeyDown(KeyCode.Space) && groundcheck.touches > 0)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
        }


    }
    private void OnCollisionEnter2D(Collision2D Die)
    {
        if (Die.gameObject.tag == "Killplayer")
        {
            Instantiate(Deatheffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
