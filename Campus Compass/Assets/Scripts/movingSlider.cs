using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MovingSlider : MonoBehaviour
{
    public Slider slider;
    public float speed = 1f;
    public float minValue = 0f;
    public float maxValue = 1f;

    private bool increasing = true;

    void Update()
    {
        // Move the slider handle based on speed
        if (increasing)
            slider.value += speed * Time.deltaTime;
        else
            slider.value -= speed * Time.deltaTime;

        // Reverse direction when reaching min or max value
        if (slider.value >= maxValue || slider.value <= minValue)
            increasing = !increasing;
    }
}
