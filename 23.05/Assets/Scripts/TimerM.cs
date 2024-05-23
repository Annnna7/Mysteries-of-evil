using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerM : MonoBehaviour
{
    public float timeStart = 60;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        if (DropdownExample.isDiff)
        {
            timeStart -= 20;
        }
        timerText.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();
        if(timeStart < 0)
        {
            SceneManager.LoadScene("Screamer");
        }
    }
}
