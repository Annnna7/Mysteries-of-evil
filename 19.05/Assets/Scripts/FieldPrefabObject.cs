using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldPrefabObject
{
    private int _row;
    private int _col;
    private GameObject _instance;

    public FieldPrefabObject(GameObject instance, int row, int col)
    {
        _instance = instance;
        _row = row;
        _col = col;
    }

    public bool IsChangeAble = true;

    public void ChangeColorToGreen()
    {
        _instance.GetComponent<Image>().color = Color.green;
    }

    public void ChangeColorToRed()
    {
        _instance.GetComponent<Image>().color = Color.red;
    }

    public void ChangeColorToWhite()
    {
        _instance.GetComponent<Image>().color = new Color(1f, 0.92f, 0.92f);
    }

    public int Row { get => _row; set => _row = value; }
    public int Col { get => _col; set => _col = value; }

    public void SetHoverMode()
    {
        _instance.GetComponent<Image>().color = new Color(0.60f, 0.44f, 0.44f);
    }

    public void UnsetHoverMode()
    {
        _instance.GetComponent<Image>().color = new Color(1f, 1f, 1f);
    }

    public int Number;
    public void SetNumber(int number)
    {
        Number = number;
        _instance.GetComponentInChildren<Text>().text = number.ToString();
    }
}
