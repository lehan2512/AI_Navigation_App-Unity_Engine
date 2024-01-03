using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public void SaveLoginStatus()
    {
        PlayerPrefs.SetInt("IsLoggedIn", 1);
        PlayerPrefs.Save();
    }

    public void CheckIfLoggedIn()
    {
        if (PlayerPrefs.HasKey("IsLoggedIn") && PlayerPrefs.GetInt("IsLoggedIn") == 1)
        {
            SceneManager.LoadScene("Main");
        }
        else
        {
            SceneManager.LoadScene("CreateAccount");
        }
    }

    public void LogOut()
    {
        PlayerPrefs.DeleteKey("IsLoggedIn");
        PlayerPrefs.Save();
    }
}
