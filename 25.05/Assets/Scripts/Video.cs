using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Video : MonoBehaviour
{
    private float timer = 0f;

    private void Update()
    {
        // Увеличиваем таймер каждый кадр
        timer += Time.deltaTime;

        // Проверяем, прошло ли уже 30 секунд
        if (timer >= 29f)
        {
            SceneManager.LoadScene("End");
        }
    }
}
