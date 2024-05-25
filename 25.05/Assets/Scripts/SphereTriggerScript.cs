using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereTriggerScript : MonoBehaviour
{
    public int myNumber = 0;
    // Обработчик события входа триггера
    private void OnTriggerEnter(Collider other)
    {
        if (myNumber == 0 && SceneManage.number == 0)
        {
            SceneManager.LoadScene("2Differences");
            SceneManage.PlusScene();
            return;
        }
        if (myNumber == 1 && SceneManage.number == 1)
        {
            SceneManager.LoadScene("SimpPuzz");
            SceneManage.PlusScene();
            return;
        }
        if (myNumber == 2 && SceneManage.number == 2)
        {
            SceneManager.LoadScene("Sudoku2");
            SceneManage.PlusScene();
            return;
        }
        if (myNumber == 3 && SceneManage.number == 3)
        {
            SceneManager.LoadScene("next");
            SceneManage.PlusScene();
            return;
        }
        if (myNumber == 4 && SceneManage.number == 4)
        {
            SceneManager.LoadScene("Differences");
            SceneManage.PlusScene();
            return;
        }
        if (myNumber == 5 && SceneManage.number == 5)
        {
            SceneManager.LoadScene("SimpPuzz2");
            SceneManage.PlusScene();
            return;
        }
        if (myNumber == 6 && SceneManage.number == 6)
        {
            SceneManager.LoadScene("next2");
            SceneManage.PlusScene();
            return;
        }
        if (myNumber == 7 && SceneManage.number == 7)
        {
            SceneManager.LoadScene("Sudoku");
            SceneManage.PlusScene();
            return;
        }
        if (myNumber == 10 || myNumber == 9)
        {
            if (SceneManage.number >= 8 && SceneManage.gameWin >= 4)
                SceneManager.LoadScene("Happy");
            else if(SceneManage.number >= 8 && SceneManage.gameWin < 4)
                SceneManager.LoadScene("TheEnd");
            else
                SceneManager.LoadScene("Base");
            return;
        }
    }

}

