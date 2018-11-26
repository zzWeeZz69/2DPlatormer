using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEffect : MonoBehaviour
{
    // säger vad är Deatheffecten
    public GameObject Deatheffect;
    

    private void OnCollisionEnter2D(Collision2D Die)
    {
        if (Die.gameObject.tag == "Killplayer")
        {
            //Spelar "Deatheffect" vart spelarn är
            // förstör spelarn när Den träffar något med Tagg "Killplayer"
            Instantiate(Deatheffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
