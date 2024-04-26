using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        myText.text = inStock + "/" + myNumber;
        if (inStock == myNumber)
        {
            SceneManager.LoadScene("WinEnd");
            myTimer.enabled = false;
        }
        if (inStock != myNumber & myTimer.myTime < 1)
        {
            SceneManager.LoadScene("Screamer");
            myTimer.enabled = false;
        }
    }
}
