using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
    public GameObject DeathEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
        Instantiate(DeathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        }
    }
}
