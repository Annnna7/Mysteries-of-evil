using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseMusic : MonoBehaviour
{
    void Start()
    {
        AudioManager.instance.Play("Base");
        if (SceneManager.GetActiveScene().name == "next" || SceneManager.GetActiveScene().name == "Difference" || SceneManager.GetActiveScene().name == "SimpPuzz" || SceneManager.GetActiveScene().name == "Sudoku")
        {
            AudioManager.instance.Stop("Base");
        }
    }
}
