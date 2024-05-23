using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    static bool _START;
    static float Sound_Volume;
    public Slider volumeSlider;
    void Start()
    {
        if (_START)
        {
            AudioListener.volume = Sound_Volume;
            volumeSlider.value = Sound_Volume;
        }
        volumeSlider.onValueChanged.AddListener(delegate { Change(); });
    }
    public void Change()
    {
        AudioListener.volume = volumeSlider.value;
        Sound_Volume = volumeSlider.value;
        _START = true;
    }
    void Update()
    {

    }
}
