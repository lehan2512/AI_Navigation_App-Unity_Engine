using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdjustNavigationPanel : MonoBehaviour
{


    [SerializeField]
    private List<Target> navTargetObjectList = new List<Target>();

    public Transform[] TargetObjects;
    public Transform Indicator;
    public  TextMeshProUGUI DistanceText;
    public TextMeshProUGUI DestinationText;

    private int DestinationPosition = 0;

    // Start is called before the first frame update
    void Start()
    {

        DestinationPosition = FindGameObject(PlayerPrefs.GetString("Destination"));
        DestinationText.text = PlayerPrefs.GetString("Destination");

    }

    // Update is called once per frame
    void Update()
    {
        string Distance = CalculateDistance();
        if (double.Parse(Distance) < 0.5 )
        {
            SceneManager.LoadSceneAsync("ArrivedAtDestination");
        }
        DistanceText.text = Distance + " m";   
    }

    private int FindGameObject(string name)
    {
        int i = 0;
        for (i = 0; i < navTargetObjectList.Count; i++)
        {
            if (navTargetObjectList[i].Name == name)
            {
                break;
            }
        }
        return i;
    }

    private string CalculateDistance()
    {
        Transform Destination = TargetObjects[DestinationPosition];

        float Distance = Vector3.Distance(Indicator.position, Destination.position);

        return Math.Round(Distance,1).ToString(); 
    }
}
