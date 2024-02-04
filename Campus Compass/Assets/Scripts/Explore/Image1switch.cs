using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    public Sprite img1;
    public Sprite img8;

    private Image imageComponent;

    void Start()
    {
        // Assuming the script is attached to an Image component
        imageComponent = GetComponent<Image>();

        // Set the initial image to img1
        imageComponent.sprite = img1;
    }

    public void OnImageClick()
    {
        // Check if the current sprite is img1
        if (imageComponent.sprite == img1)
        {
            // Switch to img8
            imageComponent.sprite = img8;
        }
        else
        {
            // Switch back to img1
            imageComponent.sprite = img1;
        }
    }
}
