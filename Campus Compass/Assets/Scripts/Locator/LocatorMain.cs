using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocatorMain : MonoBehaviour
{
    public void LoadLocatorSceneOnClick()
    {
        SceneManager.LoadSceneAsync("Locator");
    }
}
