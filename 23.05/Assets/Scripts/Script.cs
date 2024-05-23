using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Counter myCounter;
    public static bool isCliked;
    private void Update()
    {
        int a = myCounter.inStock;
        if (Input.GetMouseButtonDown(0)) { 
            Debug.Log("AAAAAAAAAAAA");
        }
        isCliked = false;
    }
}
