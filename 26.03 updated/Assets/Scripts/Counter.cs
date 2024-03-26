using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        if(inStock == myNumber)
        {
            myImage.GetComponent<Image>().enabled = true;
            myImage.transform.GetChild(0).GetComponent<Image>().enabled = true;
            myTimer.enabled = false;
        }
        if (inStock != myNumber & myTimer.myTime < 1)
        {
            myImage.GetComponent<Image>().enabled = true;
            myImage.transform.GetChild(1).GetComponent<Image>().enabled = true;
            myTimer.enabled = false;
        }
    }
}
