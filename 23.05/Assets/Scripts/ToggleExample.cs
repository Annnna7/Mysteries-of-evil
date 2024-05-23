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
        // ��������� ��������� ������� �� ��������� ��������� Toggle
        toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggle);
        });
    }

    // �����, ���������� ��� ��������� ��������� Toggle
    void ToggleValueChanged(Toggle change)
    {
        isLight = change.isOn;
    }
}