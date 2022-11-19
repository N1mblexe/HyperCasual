using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISystem : MonoBehaviour
{
    public static bool gameIsPaused,gameIsStarted;

    public GameObject PauseMenu;

    public GameObject SettingsMenu;

    public GameObject Panel;

    public AudioSource Theme;

    public GameObject PauseSettingsMenu;

    public GameObject StartMenu;

    public GameObject DailyMission;

   void Update()
   {
       if (Input.GetKeyDown(KeyCode.Escape))
       {
           if (gameIsPaused)
           {
               Resume();
           }
           else
           {
               Pause();
           }
       }
   }
  
    public void CloseDailyMission()
    {
        StartMenu.SetActive(true);
        DailyMission.SetActive(false);
        Panel.SetActive(true);
        
    }
   public void Resume()
   {
        StartMenu.SetActive(true);
        PauseMenu.SetActive(false);
       Panel.SetActive(true);
       Time.timeScale = 1f;
       gameIsPaused = false;
   }
  
   public void Pause()
   {
        StartMenu.SetActive(false);
        PauseMenu.SetActive(true);
       Panel.SetActive(true);
       Time.timeScale = 0f;
       gameIsPaused = true;
   }
  
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowSettings()
    {
        StartMenu.SetActive(false);
        PauseMenu.SetActive(false);
        SettingsMenu.SetActive(true);
        gameIsPaused = true;
    }

    public void ShowStartMenu()
    {
        StartMenu.SetActive(true);
        PauseMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        gameIsPaused = true;


    }

    public void SetQuality(int qual)
    {
        QualitySettings.SetQualityLevel(qual);
    }

    public void SetFullscreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }

    public void SetMusic(bool isMusic)
    {
        Theme.mute = !isMusic;
    }
    public void PauseSettings()
    {
        StartMenu.SetActive(false);
        PauseMenu.SetActive(false);
        PauseSettingsMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void PauseSettingsClose()
    {
        PauseMenu.SetActive(true);
        PauseSettingsMenu.SetActive(false);
        StartMenu.SetActive(false);

    }
  
    public void EndGame()
    {
        Application.Quit();
    }
}