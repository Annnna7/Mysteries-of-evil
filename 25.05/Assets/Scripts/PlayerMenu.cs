using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMenu : MonoBehaviour
{
    public bool isPaused;
    public bool isOpen = false;
    public GameObject pauseMenuUi;
    public GameObject settingsMenu;

    void Update()
    {
        if (isPaused)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused && !isOpen)
            {
                Resume();
            }
            else if (!isOpen)
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void ResumeButton()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void MenuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("_Menu");
        ResumeGame.isRes = true;
    }
    public void Settings()
    {
        pauseMenuUi.SetActive(false);
        settingsMenu.SetActive(true);
        isOpen = true;
    }

    public void Back()
    {
        pauseMenuUi.SetActive(true);
        settingsMenu.SetActive(false);
        isOpen = false;
    }
}
