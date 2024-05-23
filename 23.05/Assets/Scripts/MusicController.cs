using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public string musicToDisable; // �������� ������, ������� ����� ���������

    void Awake()
    {
        GameObject[] musicPlayers = GameObject.FindGameObjectsWithTag("MusicPlayer"); // ����� ��� ������� � �������

        // ������ �� ���� �������� � �������
        foreach (GameObject player in musicPlayers)
        {
            if (player.name == musicToDisable)
            {
                player.SetActive(false); // ��������� ������ � ��������� ������
            }
        }
    }
}
