using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NameInputManager : MonoBehaviour
{
    public static NameInputManager scene1;
    public TMP_InputField inputField;

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

    public void GetUserName()
    {
        user_name = inputField.text;
        SceneManager.LoadSceneAsync("Main");
    }

}
