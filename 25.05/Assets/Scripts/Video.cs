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
        // ����������� ������ ������ ����
        timer += Time.deltaTime;

        // ���������, ������ �� ��� 30 ������
        if (timer >= 29f)
        {
            SceneManager.LoadScene("End");
        }
    }
}
