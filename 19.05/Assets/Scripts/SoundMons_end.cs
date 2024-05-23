using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class SoundMons_end : MonoBehaviour
{
    private GameObject Player;
    private bool isChasing = false;
    public AudioClip approachingSound;
    private AudioSource audioSource;
    private float maxVolume = 1.0f; // ������������ ���������
    private float minVolume = 0.0f; // ����������� ���������
    private float maxDistance = 10f; // ������������ ���������� ��� ������������ ���������

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = approachingSound;
        audioSource.volume = minVolume; // ������������� ��������� ���������
        audioSource.loop = true;

        StartCoroutine(StartChasing());
    }

    IEnumerator StartChasing()
    {
        yield return new WaitForSeconds(8f); // ���� �������� ���������� ������
        isChasing = true;
    }

    void Update()
    {
        if (isChasing)
        {
            if (Player != null)
            {
                float distance = Vector3.Distance(transform.position, Player.transform.position);
                float volume = 1.0f - Mathf.Clamp01(distance / maxDistance); // ��������� ��������� �� ������ ����������
                audioSource.volume = Mathf.SmoothStep(minVolume, maxVolume, volume);

                if (!audioSource.isPlaying && volume > 0)
                {
                    audioSource.Play();
                }
            }
        }
    }
}
