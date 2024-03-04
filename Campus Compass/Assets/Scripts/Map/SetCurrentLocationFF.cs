using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class SetCurrentLocation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string currentLocation = PlayerPrefs.GetString("Location");

        if (currentLocation != "Entrance")
        {

            if (currentLocation == "Library")
            {
                transform.position = new Vector3(0, 0, 2.66f);
            }
            else if (currentLocation == "Student Ambassador")
            {
                transform.position = new Vector3(0, 0, 4.73f);

            }
            else if(currentLocation == "Staff Office")
            {
                transform.position = new Vector3(0, 0, 10.66f);
            }
            else if (currentLocation == "Washrooms")
            {
                transform.position = new Vector3(0, 0, 11.39f);
            }
            
        }

    }
}
