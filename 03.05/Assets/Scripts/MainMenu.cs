using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(int Number)
    {
        SceneManager.LoadScene(9);
    }
    public void QuitGame()
    {
        Debug.Log("Game is close");
        Application.Quit();
    }
}
