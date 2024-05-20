using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Monster_end : MonoBehaviour
{
    private GameObject Player;
    private NavMeshAgent agent;
    private bool isChasing = false;
    private float delay = 8f; // Задержка в секундах

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(StartChasing());
    }

    IEnumerator StartChasing()
    {
        yield return new WaitForSeconds(delay); // Ждем заданное количество секунд
        isChasing = true;
    }

    void Update()
    {
        if (isChasing)
        {
            agent.SetDestination(Player.transform.position);

            // Проверяем расстояние между врагом и игроком
            float distance = Vector3.Distance(transform.position, Player.transform.position);
            if (distance < 2f) // Если расстояние меньше 2 единиц, переключаем на другую сцену
            {
                SceneManager.LoadScene("TheLast");
            }
        }
    }
}