using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    /*public float wallDistance; // Расстояние от стены, на котором должна остановиться камера

    void Update()
    {
        RaycastHit hit;
        Vector3 direction = Camera.main.transform.position - transform.position;

        if (Physics.Raycast(transform.position, direction, out hit, direction.magnitude))
        {
            if (hit.collider.tag == "Wall")
            {
                // Если луч попал в стену, переместите камеру на позицию удара с учетом wallDistance
                Camera.main.transform.position = hit.point + hit.normal * wallDistance;
            }
        }
    }*/

    public float wallDistance; // Расстояние от стены, на котором должна остановиться камера
    //public float playerDistance = 1f; // Расстояние от игрока до стены

    void Update()
    {
        RaycastHit hit;
        Vector3 direction = Camera.main.transform.position - transform.position;

        if (Physics.Raycast(transform.position, direction, out hit, direction.magnitude))
        {
            if (hit.collider.tag == "Wall" && hit.distance < wallDistance)
            {
                // Если луч попал в стену и расстояние до стены меньше wallDistance, переместите камеру на позицию удара с учетом wallDistance
                Camera.main.transform.position = hit.point + hit.normal * wallDistance;
            }

            //if (hit.collider.tag == "Player" && hit.distance < playerDistance)
           
                // Если луч попал в игрока и расстояние до игрока меньше playerDistance, не давать игроку пройти дальше заданного расстояния к стенам
                // Можно добавить здесь логику остановки движения игрока или другие действия
            
        }
    }
}
