using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenMenu()
    {
        SceneManager.LoadScene("_Menu");
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("Base");
    }
    public void OpenDifferences()
    {
        SceneManager.LoadScene("Differences");
    }
    public void OpenSudoku()
    {
        SceneManager.LoadScene("Sudoku");
    }
    public void OpenSimpPuzz()
    {
        SceneManager.LoadScene("SimpPuzz");
    }
    public void OpenNext()
    {
        SceneManager.LoadScene("next");
    }
}
