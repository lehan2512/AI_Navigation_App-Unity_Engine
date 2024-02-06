using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSettings : MonoBehaviour
{
    
    public void SettingsMain()
    {
        SceneManager.LoadSceneAsync("Settings");

    }

    public void EditNameMain()
    {
        SceneManager.LoadSceneAsync("EditName");

    }
    

}