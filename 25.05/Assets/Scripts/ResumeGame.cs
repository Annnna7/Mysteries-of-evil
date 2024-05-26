using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeGame : MonoBehaviour
{
    public static bool isRes;
    public GameObject newGameobj;
    void Start()
    {
        if (!isRes)
        {
            newGameobj.SetActive(false);
        }
    }
}
