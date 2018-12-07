using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// lägger till en GameObject prefab som är en effect på "coin"'s platts men vi vill inte ha samma rotation som Coin så då andvänder vi Quaternion.identity så det inte hänner

public class KillPlayer : MonoBehaviour
{
    // om den träffar ett GameObject men taggen Player börja en timer på 0.5 sek
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
            StartCoroutine(LoadSceneAfterTime(0.5f));
            
            
        }
    }
    // om den träffar ett GameObject men taggen Player börja en timer på 0.5 sek
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
            StartCoroutine(LoadSceneAfterTime(0.5f));

            
        }
    }


    // när timer är över så laddar den in den scenen spelaren är på
    public IEnumerator LoadSceneAfterTime(float time)
    {
        Debug.Log("Hit3");
        yield return new WaitForSeconds(time);
        Scene active = SceneManager.GetActiveScene();
        SceneManager.LoadScene(active.name);
    }
}
