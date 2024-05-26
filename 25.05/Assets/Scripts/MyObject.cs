using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyObject : MonoBehaviour
{
    private Camera mainCamera;
    private float camWidth;
    private float camHeight;

    void Start()
    {
        mainCamera = Camera.main;
        camHeight = mainCamera.orthographicSize;
        camWidth = camHeight * mainCamera.aspect;
    }

    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, -camWidth, camWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, -camHeight, camHeight);
        transform.position = viewPos;
    }
}
