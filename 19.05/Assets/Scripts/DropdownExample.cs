using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownExample : MonoBehaviour
{
    public Dropdown dropdown;
    public static bool isDiff;
    // Start is called before the first frame update
    void Start()
    {
        // ���������� ��������� ������� �� ��������� ���������� ��������
        dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(dropdown);
        });
    }

    // �����, ���������� ��� ��������� ���������� ��������
    void DropdownValueChanged(Dropdown change)
    {
        if (change.value == 1)
        {
            isDiff = true;
        }
        if (change.value == 0)
        {
            isDiff = false;
        }
    }
}
