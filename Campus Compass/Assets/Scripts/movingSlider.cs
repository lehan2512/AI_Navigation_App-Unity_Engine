using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderController : MonoBehaviour
{
    public Slider slider;
    public Text valueText; // Optional: If you want to display the current value of the slider.

    // This method is called when the slider's value changes.
    public void OnSliderValueChanged()
    {
        // Optional: Update a text field to display the current value of the slider.
        if (valueText != null)
        {
            valueText.text = slider.value.ToString();
        }

        // Here you can add any other logic you want to execute when the slider's value changes.
    }
}
