using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisible : MonoBehaviour
{
    public int myNumber;
    public GameObject newObject; // ������ �� �������� ������
    void Update()
    {
        if (myNumber != SceneManage.number)
        {
            newObject.SetActive(false);
        }
    }
}
