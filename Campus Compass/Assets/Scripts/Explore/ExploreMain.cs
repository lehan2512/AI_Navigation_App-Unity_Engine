using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Explore : MonoBehaviour
{
    public void LoadExploreSceneOnClick()
    {
        SceneManager.LoadSceneAsync("ExploreMain");
        
    }
}
