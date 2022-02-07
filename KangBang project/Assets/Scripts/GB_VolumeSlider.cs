using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GB_VolumeSlider : MonoBehaviour
{
    Slider slider;
    public static float volumeSlider;

    private void Awake()
    {
        GB_VolumeSlider.volumeSlider = 1f;
    }

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = volumeSlider;
    }

    void Update()
    {
        volumeSlider = slider.value;
    }
}
