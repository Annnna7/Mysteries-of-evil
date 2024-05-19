using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour
{
    private Renderer objectRenderer;
    public int myNumber = 0;
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        objectRenderer.enabled = false;
        if (myNumber == SceneManage.number)
        {
            objectRenderer.enabled = true;
        }
    }

    /*void Update()
    {
        // При нажатии клавиши "V" меняем видимость объекта
        if (Input.GetKeyDown(KeyCode.V))
        {
            objectRenderer.enabled = !objectRenderer.enabled;
        }
    }*/
}
