using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Screamer : MonoBehaviour
{
    private float gameTime;
    public int myTime = 5;
    void Start()
    {
        
    }

    void Update()
    {
        gameTime += 1 * Time.deltaTime;
        if (gameTime > 1)
        {
            myTime -= 1;
            gameTime = 0;
        }

        if (myTime < 0)
        {
            SceneManager.LoadScene("Base");
        }
    }
}
