using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{

    public void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            StartCoroutine( LoadSceneAfterTime(3f) );
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }

    }

    public IEnumerator LoadSceneAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        Scene active = SceneManager.GetActiveScene();
        SceneManager.LoadScene(active.name);
    }
}
