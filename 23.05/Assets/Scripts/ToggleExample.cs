using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleExample : MonoBehaviour
{
    public Toggle toggle;
    public static bool isLight;
    void Start()
    {
        if (isLight)
        {
            toggle.enabled = true;
        }
        // Добавляем слушатель события на изменение состояния Toggle
        toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggle);
        });
    }

    // Метод, вызываемый при изменении состояния Toggle
    void ToggleValueChanged(Toggle change)
    {
        isLight = change.isOn;
    }
}