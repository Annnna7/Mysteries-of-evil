using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(int Number)
    {
        SceneManager.LoadScene(7);
        SceneManage.gameWin = 0;
        SceneManage.number = 0;
    }
    public void QuitGame()
    {
        Debug.Log("Game is close");
        Application.Quit();
    }

    public void ResumeGame(int Number)
    {
        SceneManager.LoadScene(7);
    }
}
