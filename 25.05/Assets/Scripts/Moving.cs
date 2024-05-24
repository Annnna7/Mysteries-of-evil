using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Moving : MonoBehaviour
{
    bool move; //����������� 
    Vector2 mousePos; //������ 
    float startPosX;
    float startPosY;
    public GameObject form; //���������� �����-�������� 
    private bool placed = false; //� ������ �� ����� ���� 
    private bool isTransparent = false; // ������������

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            move = true;
            mousePos = Input.mousePosition;
            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            // ������� ������� ���������� ��� �������
            isTransparent = true;
            ChangeTransparency(0.5f); // ������ �������� ������������ (0.5f)
        }
    }

    void ChangeTransparency(float alphaValue)
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Color color = spriteRenderer.color;
        color.a = alphaValue;
        spriteRenderer.color = color;
    }

    void OnMouseUp()
    {
        move = false;
        if (isTransparent)
        {
            ChangeTransparency(1f); // ������� ������������ ������� � 100%
            isTransparent = false;
        }

        move = false;
        if(Mathf.Abs(this.transform.localPosition.x - form.transform.localPosition.x) <= 25f && Mathf.Abs(this.transform.localPosition.y - form.transform.localPosition.y) <= 25f)
        {
            if (!placed)
            {
                WinScript.AddElement();
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                this.transform.position = new Vector2(form.transform.position.x, form.transform.position.y);
                if(spriteRenderer != null)
                {
                    spriteRenderer.sortingOrder = 0;
                }
                placed = true;
                GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }


    void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
        if (move == true)
        {
            mousePos = Input.mousePosition;
            this.gameObject.transform.localPosition = new Vector2(mousePos.x - startPosX, mousePos.y - startPosY);
        }
    }
}
