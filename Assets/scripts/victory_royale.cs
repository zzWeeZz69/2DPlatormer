using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victory_royale : MonoBehaviour
{
    
    //public GameObject victory;

    public void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            print("yay");
            SceneManager.LoadScene("Win");
        }

    }
}
