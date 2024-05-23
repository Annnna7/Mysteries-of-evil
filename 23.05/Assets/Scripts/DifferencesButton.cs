using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifferencesButton : MonoBehaviour
{
    public Button myButton1;
    public Button myButton2;
    private Image myImage1;
    public Counter myCounter;
    public TimerDiff myTimer;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        myButton1 = GetComponent<Button>();
        myImage1 = GetComponent<Image>();
        myButton1.onClick.AddListener(MyVoid);
    }

    void MyVoid()
    {
        if(DropdownExample.isDiff)
            myTimer.myTime += 10; 
        myCounter.inStock++;
        myImage1.color = Color.white;
        myButton2.image.color = Color.white;
        myButton1.enabled = false;
        myButton2.enabled = false;
    }

}
