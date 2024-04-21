using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifferencesButton : MonoBehaviour
{
    private Button myButton;
    private Image myImage;
    public Counter myCounter;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        myButton = GetComponent<Button>();
        myImage = GetComponent<Image>();
        myButton.onClick.AddListener(MyVoid);
    }

    void MyVoid()
    {
        myCounter.inStock++;
        myImage.color = Color.white;
        myButton.enabled = false;
    }
}
