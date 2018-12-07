using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
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

        // om scenen Tutorial är laddad så set gameobject ScoreText till false annas true
        if(SceneManager.GetActiveScene().name == "Tutorial")
        {
            ScoreText.SetActive(false);
        }
        else
        {
            ScoreText.SetActive(true);
        }

        // gör UI nycklen aktive när Boolen blir true
        if(KeyActive == true)
        {
            FullKey.SetActive(true);
            EmptyKey.SetActive(false);
        }

    // gör UI nycken inte aktive när boolen  blir false
        if(KeyActive == false)
        {
            FullKey.SetActive(false);
            EmptyKey.SetActive(true);
        }
    }

    // sätter tiden som spelet kör i till 1 som är "normal hastiget" för tiden och stänger av PauseMenun
    public void Resume()
    {
        PauseGameUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    // sätter tiden som spelet kör i till 0 som stanar tiden helt och sätter på Pause menun
    void Pause()
    {
        PauseGameUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    // laddar in main menu när voiden körs
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    // stägger av spelet när voiden körs
    public void QuitGame()
    {
        Application.Quit();
    }
}
