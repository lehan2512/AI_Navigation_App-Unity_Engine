using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadExploreHighlight : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMainSceneOnClick()
    {
        SceneManager.LoadSceneAsync("ExploreScene");

    }
}
