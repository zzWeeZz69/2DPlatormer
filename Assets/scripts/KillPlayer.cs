using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillPlayer : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
            StartCoroutine(LoadSceneAfterTime(0.5f));
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
    

    public IEnumerator LoadSceneAfterTime(float time)
    {
        Debug.Log("Hit3");
        yield return new WaitForSeconds(time);
        Scene active = SceneManager.GetActiveScene();
        SceneManager.LoadScene(active.name);
    }
}
