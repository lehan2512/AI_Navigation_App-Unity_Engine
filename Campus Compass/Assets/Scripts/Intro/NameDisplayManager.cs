using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NameDisplayManager : MonoBehaviour
{
    public TextMeshProUGUI nameText; // Reference to the TextMeshProUGUI

    void Start()
    {
        string storedName = PlayerPrefs.GetString("Username"); // Retrieve the stored name

        if (!string.IsNullOrEmpty(storedName))
        {
            nameText.text = storedName; // Display the retrieved name
        }
        else
        {
            Debug.LogWarning("Player name not found!");
        }
    }
}
