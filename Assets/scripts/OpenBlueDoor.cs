using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBlueDoor : MonoBehaviour
{
    public PauseMenu PauseMenu;
    public GameObject Doors;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && PauseMenu.KeyActive == true)
        {
            Doors.SetActive(false);
        }
    }
}
