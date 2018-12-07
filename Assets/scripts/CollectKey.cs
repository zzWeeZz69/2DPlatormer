using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public GameObject Effect;
    public UI PauseMenu;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Activatekey();
        // lägger till en GameObject prefab som är en effect på "coin"'s platts men vi vill inte ha samma rotation som Coin så då andvänder vi Quaternion.identity så det inte hänner
        Instantiate(Effect, transform.position, Quaternion.identity);

        // tar bort "key"
        Destroy(gameObject);
    }

    void Activatekey()
    {
        // tar variablen KeyActive från PauseMenu
        PauseMenu.KeyActive = true;
    }
}
