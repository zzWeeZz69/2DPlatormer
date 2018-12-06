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
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
        
    }

}
