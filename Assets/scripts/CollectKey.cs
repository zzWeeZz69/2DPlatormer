﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public GameObject Effect;
    public PauseMenu PauseMenu;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Effect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
