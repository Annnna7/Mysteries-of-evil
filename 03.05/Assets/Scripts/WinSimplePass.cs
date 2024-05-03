using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSimplePass : MonoBehaviour
{
    int fullElement;//???-?? ???? ????????? ?????
    public static int myElement;//????? ?????????,??????? ?? ????? ?????
    public GameObject Panel;//
    public GameObject winPanel;
    public GameObject time;
    // Start is called before the first frame update
    void Start()
    {
        fullElement = 8;
    }

    // Update is called once per frame
    void Update()
    {
        if (fullElement == myElement)
        {
            Panel.SetActive(false);
            winPanel.SetActive(true);
            time.SetActive(false);
        }
    }

    public static void AddElement()
    {
        myElement++;
    }
}

