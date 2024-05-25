using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    /*public float wallDistance; // ���������� �� �����, �� ������� ������ ������������ ������

    void Update()
    {
        RaycastHit hit;
        Vector3 direction = Camera.main.transform.position - transform.position;

        if (Physics.Raycast(transform.position, direction, out hit, direction.magnitude))
        {
            if (hit.collider.tag == "Wall")
            {
                // ���� ��� ����� � �����, ����������� ������ �� ������� ����� � ������ wallDistance
                Camera.main.transform.position = hit.point + hit.normal * wallDistance;
            }
        }
    }*/

    public float wallDistance; // ���������� �� �����, �� ������� ������ ������������ ������
    //public float playerDistance = 1f; // ���������� �� ������ �� �����

    void Update()
    {
        RaycastHit hit;
        Vector3 direction = Camera.main.transform.position - transform.position;

        if (Physics.Raycast(transform.position, direction, out hit, direction.magnitude))
        {
            if (hit.collider.tag == "Wall" && hit.distance < wallDistance)
            {
                // ���� ��� ����� � ����� � ���������� �� ����� ������ wallDistance, ����������� ������ �� ������� ����� � ������ wallDistance
                Camera.main.transform.position = hit.point + hit.normal * wallDistance;
            }

            //if (hit.collider.tag == "Player" && hit.distance < playerDistance)
           
                // ���� ��� ����� � ������ � ���������� �� ������ ������ playerDistance, �� ������ ������ ������ ������ ��������� ���������� � ������
                // ����� �������� ����� ������ ��������� �������� ������ ��� ������ ��������
            
        }
    }
}
