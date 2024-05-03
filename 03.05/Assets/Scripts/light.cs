using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public float minIntensity = 0.5f;
    public float maxIntensity = 1.5f;
    public float flickerSpeed = 1.0f;

    private Light lightComponent;

    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    void Update()
    {
        float intensity = Mathf.PingPong(Time.time * flickerSpeed, 1.0f);
        lightComponent.intensity = Mathf.Lerp(minIntensity, maxIntensity, intensity);
    }
}
