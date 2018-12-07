using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int score = 1;
    public GameObject CoinEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // kolla om Triggern har träffat spelan med tag "Player"
        if (collision.tag == "Player")
        {
            // skapa en tremporär variabel "controller och sätt den till
            // resultatet av sökningen efter objektet med taggen "GameController"
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                // hittar "tracker variablen från scripten ScoreTracker
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.totalscore += score;
                }
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController");
                }
            }
            else
            {
                Debug.LogError("GameController finns inte");
            }
            // lägger till en GameObject prefab som är en effect på "coin"'s platts men vi vill inte ha samma rotation som Coin så då andvänder vi Quaternion.identity så det inte hänner
            Instantiate(CoinEffect, transform.position, Quaternion.identity);

            //förstör Coin
            Destroy(gameObject);
        }
    }
}