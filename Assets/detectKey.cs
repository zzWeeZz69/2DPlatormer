using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectKey : MonoBehaviour
{
    public PauseMenu Pause;
    public bool keyValue;
    private void Start()
    {
        Pause.KeyActive = keyValue;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            keyValue = true;
        }
    }
}
