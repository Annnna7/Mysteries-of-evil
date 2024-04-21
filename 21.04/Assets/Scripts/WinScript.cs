using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    int fullElement;//Кол-во всех элементов пазла
    public static int myElement;//Число элементов,лежащих на своем месте
    public GameObject Puzzle;//Объект, содержащий все элементы пазла для сбора
    public GameObject Panel;//Панель с пазлами
    public GameObject winPanel;//Панель победы
    public GameObject time;//выключить время
    // Start is called before the first frame update
    void Start()
    {
        fullElement = Puzzle.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(fullElement == myElement)
        {
            //Panel.SetActive(false);
            SceneManager.LoadScene("WinEnd");
            //winPanel.SetActive(true);  
            //time.SetActive(false);
        }
    }

    public static void AddElement()
    {
        myElement++;
    }
}
