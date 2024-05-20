using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Counter : MonoBehaviour
{
    private Text myText;
    [HideInInspector]
    public int inStock;
    public int myNumber = 5;
    public Image myImage;
    public TimerDiff myTimer;
    void Start()
    {
        myText = GetComponent<Text>();
    }

    void Update()
    {
        if (DropdownExample.isDiff)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Invoke("DelayedMethod", 0.1f);
            }
        }
        myText.text = inStock + "/" + myNumber;
        if (inStock == myNumber)
        {
            SceneManage.PlusWin();
            SceneManager.LoadScene("WinEnd");
            myTimer.enabled = false;
        }
        if (inStock != myNumber & myTimer.myTime < 1)
        {
            SceneManager.LoadScene("Screamer");
            myTimer.enabled = false;
        }
    }

    void DelayedMethod()
    {
        myTimer.myTime -= 10;
    }
}
