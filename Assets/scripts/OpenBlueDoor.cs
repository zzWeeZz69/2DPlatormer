using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBlueDoor : MonoBehaviour
{
    public UI PauseMenu;
    public GameObject Doors;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //omspelaren träffar väggen och har nycklen så gör den dörren "false"
        if(collision.gameObject.tag == "Player" && PauseMenu.KeyActive == true)
        {
            Doors.SetActive(false);
        }
    }
}
