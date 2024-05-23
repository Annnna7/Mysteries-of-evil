using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDiff : MonoBehaviour
{
    private Text myText;
    private float gameTime;
    public int myTime = 60;

    void Start()
    {
        myText = GetComponent<Text>();
    }

    void Update()
    { 
        myText.text = "Time:" + myTime;
        gameTime += 1 * Time.deltaTime;
        if (gameTime > 1)
        {
            myTime -= 1;
            gameTime = 0;
        }
    }
}
