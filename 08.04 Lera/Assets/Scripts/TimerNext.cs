using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerNext : MonoBehaviour
{
    private TMP_Text myText;
    private float gameTime;
    public int myTime = 60;

    void Start()
    {
        myText = GetComponent<TMP_Text>();
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
        if (myTime < 1)
        {
            SceneManager.LoadScene("Screamer");
        }
    }
}
