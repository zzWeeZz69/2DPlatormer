using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        
        
    }
    public void loadlevel(string SampleScene)
    {
        Debug.Log("You have clicked the button!");
        SceneManager.LoadScene("MainMenu");
    }
}
