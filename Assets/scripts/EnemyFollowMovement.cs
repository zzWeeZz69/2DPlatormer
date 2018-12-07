using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowMovement : MonoBehaviour
{
    [Range(0, 30f)]
    public float Speed;

    Transform Target;
    void Start()
    {
        // hämtar componenten Transform från Taggen "Player" och gör det till "Target" Transfromen
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void Update()
    {
        // tar denns positon och tar spelarn position med "(transform.position, Target.position, Speed * Time.deltaTime)" och sedan tar sig till spelarn position
        transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
        
    }

}

