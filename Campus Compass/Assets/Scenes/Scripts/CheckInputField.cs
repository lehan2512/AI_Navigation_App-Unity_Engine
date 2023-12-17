using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckInputField : MonoBehaviour
{
    public TMP_InputField myInputField; 
    public TextMeshProUGUI notificationText;

    public void CheckIfEmptyAndNotify()
    {
        if (string.IsNullOrEmpty(myInputField.text))
        {
            notificationText.text = "Hey there! It seems like you didn't input your name"; // Show the message
        }
        else
        {
            notificationText.text = ""; // Clear the message if input is not empty
        }
    }
}
