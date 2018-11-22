using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class KYS : MonoBehaviour
{
    public int deaths = 0;
    public TextMeshProUGUI deathText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("gg");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
            deathText.text = string.Format("deaths: {0}", deaths ++);
        }
    }
}
