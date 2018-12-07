using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundcheck : MonoBehaviour
{
    public int touches;

    // lägger till på touches när den träffar något
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touches++;
    }

    // tar bort från touches när den inte träffar något
    private void OnTriggerExit2D(Collider2D collision)
    {
        touches--; 
    }
}