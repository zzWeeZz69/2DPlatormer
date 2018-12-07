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

    // get det en titel
    [Header("some other variables")]
    // ger det ett mällan rum
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
        
        // hämtar rigidbody2D componetnen
        rbody = GetComponent<Rigidbody2D>();
        DashTime = StartDashTime;

    }

    // Update is called once per frame

    void Update()
    {
        
        // gör så att spelaren kan röra sig fram och till baka
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movespeed, rbody.velocity.y);

        // spelar en animaton när spelaren rör sig
        Anim.SetFloat("Speed", Mathf.Abs(rbody.velocity.x));

        // när man trycker a spå skallas spelaren om till att kolla åt vänster
        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        // när man trycker D sp skallas spelaren om till att kolla åt höger
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }


        // gör så att om du trycker "space" och "touches är större än 1 hoppar den
        if (Input.GetKeyDown(KeyCode.Space) && groundcheck.touches > 1)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);

            // spelar ett ljud från variablen Sound
            Sound.Play();
        }

       // om Diracton är lika med 0 så kan den köra rästen av det som står i "if"
       if(Diracton == 0)
        {
            // ger diarction värde av 1 när spelaren trycker Z
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Diracton = 1;
                // lägger till en GameObject prefab som är en effect på "coin"'s platts men vi vill inte ha samma rotation som Coin så då andvänder vi Quaternion.identity så det inte hänner
                Instantiate(DashEffect, transform.position, Quaternion.identity);
            }

            // ger diarction varde av 2 när spelaren trycker C
            else if (Input.GetKeyDown(KeyCode.C))
            {
                Diracton = 2;
                // lägger till en GameObject prefab som är en effect på "coin"'s platts men vi vill inte ha samma rotation som Coin så då andvänder vi Quaternion.identity så det inte hänner
                Instantiate(DashEffect, transform.position, Quaternion.identity);
            }
        }
        else
        {
            // om dashTime är eller är mindre än noll så ger den värde till diracton till 0 och gör så att den stanar
            if(DashTime <= 0)
            {
                Diracton = 0;
                DashTime = StartDashTime;
                rbody.velocity = Vector2.zero;
            }
            else
            {
                DashTime -= Time.deltaTime;
                
                // om diarcton är 1 så rör spelaren åt vänster men Dashspeed som hastighet
                if (Diracton == 1)
                {
                    rbody.velocity = Vector2.left * DashSpeed;
                }

                // om diarcton är 2 så rör spelaren åt höger men Dashspeed som hastighet
                else if (Diracton == 2)
                {
                    rbody.velocity = Vector2.right * DashSpeed;
                }
            }
        }

    }
    
}
