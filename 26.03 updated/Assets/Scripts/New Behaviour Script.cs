using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject SudokuFieldPanel;
    public GameObject FieldPrefab;
    public GameObject ControlPanel;
    public GameObject ControlPrefab;

    void Start()
    {
        CreateFieldPrefabs();
        CreateControlPrefabs();
        CreateSudokuObject();
    }

    public void ClickOnFinish()
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                FieldPrefabObject fieldObject = _fieldPrefabObject[new Tuple<int, int>(row, col)];
                if (fieldObject.IsChangeAble)
                {
                    if (_finalObject.Values[row, col] == fieldObject.Number)
                    {
                        fieldObject.ChangeColorToGreen();
                    }
                    else
                    {
                        fieldObject.ChangeColorToRed();
                    }
                }
            }
        }
    }

    private SudokuObject _gameObject; 
    private SudokuObject _finalObject;
    private void CreateSudokuObject()
    {
        SudokuGenerator.CreateSudokuObject(out SudokuObject finalObject, out SudokuObject gameObject);
        _gameObject = gameObject;
        _finalObject = finalObject;
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                var currentValue = _gameObject.Values[row, col];
                if (currentValue != 0)
                {
                    FieldPrefabObject fieldObject = _fieldPrefabObject[new Tuple<int, int>(row, col)];
                    fieldObject.ChangeColorToWhite();
                    fieldObject.SetNumber(currentValue);
                    fieldObject.IsChangeAble = false;
                }
            }
        }
    }

    private Dictionary<Tuple<int, int>, FieldPrefabObject> _fieldPrefabObject = new Dictionary<Tuple<int, int>, FieldPrefabObject>();

    private void CreateFieldPrefabs()
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                GameObject instance = GameObject.Instantiate(FieldPrefab, SudokuFieldPanel.transform);
                
                FieldPrefabObject fieldPrefabObject = new FieldPrefabObject(instance, row, col);
                _fieldPrefabObject.Add(new Tuple<int, int>(row, col), fieldPrefabObject);

                instance.GetComponent<Button>().onClick.AddListener(() => OnClick_FieldPrefab(fieldPrefabObject));
            }
        }
    }

    private void CreateControlPrefabs()
    {
        for (int i = 1; i < 10; i++)
        {
            GameObject instance = GameObject.Instantiate(ControlPrefab, ControlPanel.transform);
            instance.GetComponentInChildren<Text>().text = i.ToString();

            ControlPrefabObject controlPrefabObject = new ControlPrefabObject();
            controlPrefabObject.Number = i;

            instance.GetComponent<Button>().onClick.AddListener(() => ClickOnControlPrefab(controlPrefabObject));   
        }
    }

    private void ClickOnControlPrefab(ControlPrefabObject controlPrefabObject)
    {
        Debug.Log($"Click {controlPrefabObject.Number}");
        if (_currentHoveredFieldPrefab != null)
        {
            _currentHoveredFieldPrefab.SetNumber(controlPrefabObject.Number);
        }
    }

    private FieldPrefabObject _currentHoveredFieldPrefab;

    private void OnClick_FieldPrefab(FieldPrefabObject fieldPrefabObject)
    {
        Debug.Log($"Clicked {fieldPrefabObject.Row}, {fieldPrefabObject.Col}");
        if (fieldPrefabObject.IsChangeAble)
        {
            if (_currentHoveredFieldPrefab != null)
            {
                _currentHoveredFieldPrefab.UnsetHoverMode();
            }
            _currentHoveredFieldPrefab = fieldPrefabObject;
            fieldPrefabObject.SetHoverMode();
        }
    }
}
