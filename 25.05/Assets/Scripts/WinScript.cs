using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    int fullElement;//���-�� ���� ��������� �����
    public static int myElement;//����� ���������,������� �� ����� �����
    public GameObject Puzzle;//������, ���������� ��� �������� ����� ��� �����
    public GameObject Panel;//������ � �������
    public GameObject time;//��������� �����
    // Start is called before the first frame update
    void Start()
    {
        fullElement = Puzzle.transform.childCount;
        myElement = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(fullElement == myElement)
        {
            SceneManage.PlusWin();
            SceneManager.LoadScene("WinEnd"); 
            time.SetActive(false);
        }
    }

    public static void AddElement()
    {
        myElement++;
    }
}
