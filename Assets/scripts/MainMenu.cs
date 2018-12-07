using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // när void'en startas så laddar den in nästa scene i buildindexen
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // när void'en startas så stäger den ner spelet
    public void QuitGame()
    {
        Application.Quit();
    }
}
