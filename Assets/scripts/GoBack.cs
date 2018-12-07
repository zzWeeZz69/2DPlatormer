using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    
    public void loadlevel(string SampleScene)
    {
        Debug.Log("You have clicked the button!");
        // laddar in scenen MainMenu
        SceneManager.LoadScene("MainMenu");
    }
}
