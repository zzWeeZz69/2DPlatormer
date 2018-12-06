using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEnable : MonoBehaviour
{
    public GameObject Enemy;
    private void Start()
    {
        Enemy.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy.SetActive(true);
    }
}
