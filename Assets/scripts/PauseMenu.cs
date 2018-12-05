using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject PauseGameUI;
    public GameObject ScoreText;
    public GameObject EmptyKey;
    public GameObject FullKey;
    public bool KeyActive;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if(SceneManager.GetActiveScene().name == "Tutorial")
        {
            ScoreText.SetActive(false);
        }
        else
        {
            ScoreText.SetActive(true);
        }


        if(KeyActive == true)
        {
            FullKey.SetActive(true);
            EmptyKey.SetActive(false);
        }
        if(KeyActive == false)
        {
            FullKey.SetActive(false);
            EmptyKey.SetActive(true);
        }
    }

    public void Resume()
    {
        PauseGameUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseGameUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
