using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEnable : MonoBehaviour
{
    public GameObject Enemy;
    private void Start()
    {
        // sätter gameObjectet "enemy" av vid start
        Enemy.SetActive(false);
    }
    //kollar om något träffar Trigger collidern
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //sätter gameobjectet "enemy" på vid träff av trigger
        Enemy.SetActive(true);
    }
}
