using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckInputField : MonoBehaviour
{
    public static CheckInputField scene1;
    public TMP_InputField myInputField; 
    public TextMeshProUGUI notificationText;

    public string user_name;

    private void Awake()
    {
        if (scene1 == null)
        {
            scene1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void CheckIfEmptyAndNotify()
    {
        if (string.IsNullOrEmpty(myInputField.text))
        {
            notificationText.text = "Hey there! It seems like you didn't input your name"; // Show the message
        }
        else
        {
            notificationText.text = ""; // Clear the message if input is not empty
            user_name = myInputField.text;
            SceneManager.LoadSceneAsync("Main");
        }
    }
}
