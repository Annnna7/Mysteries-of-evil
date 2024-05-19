using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public string musicToDisable; // Название музыки, которую нужно отключить

    void Awake()
    {
        GameObject[] musicPlayers = GameObject.FindGameObjectsWithTag("MusicPlayer"); // Найти все объекты с музыкой

        // Пройти по всем объектам с музыкой
        foreach (GameObject player in musicPlayers)
        {
            if (player.name == musicToDisable)
            {
                player.SetActive(false); // Отключить музыку с указанным именем
            }
        }
    }
}
