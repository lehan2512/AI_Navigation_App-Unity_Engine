using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Drawing;
using UnityEngine.SceneManagement;

public class MoveBetweenMaps : MonoBehaviour
{
    [SerializeField] public TMP_Dropdown locationFloorDropdown;
    [SerializeField] public TMP_Dropdown locationPlaceDropdown;

    [SerializeField] public TMP_Dropdown DestinationFloorDropdown;
    [SerializeField] public TMP_Dropdown DestinationPlaceDropdown;

    public TextMeshProUGUI text;


    private string DestinationFloor;
    private string DestinationPlace;
    private string LocationFloor;
    private string LocationPlace;

    private void OptionSelected()
    {
        LocationFloor = locationFloorDropdown.options[locationFloorDropdown.value].text;
        LocationPlace = locationPlaceDropdown.options[locationPlaceDropdown.value].text;
       

        DestinationFloor = DestinationFloorDropdown.options[DestinationFloorDropdown.value].text;
        DestinationPlace = DestinationPlaceDropdown.options[DestinationPlaceDropdown.value].text;
    }

    private void MovetoMap()
    {
        if (DestinationFloor == LocationFloor )
        {
            PlayerPrefs.SetString("Location", LocationPlace);
            PlayerPrefs.SetString("Destination",DestinationPlace);
            if (DestinationFloor == "First")
            {
                SceneManager.LoadScene("First Floor");
            }

            if (DestinationFloor == "Ground")
            {
                SceneManager.LoadScene("Ground Floor");
            }



        }
        
    }


    public void checkError()
    {
        OptionSelected();
        string pickedLocation = LocationFloor + " " + LocationPlace;
        string pickedDestination = DestinationFloor + " " + DestinationPlace;

        if ( pickedLocation == pickedDestination)
        {
            text.color = UnityEngine.Color.red;

        }
        else
        {
            MovetoMap();
        }

        if (LocationFloor != DestinationFloor)
        {
            SceneManager.LoadScene("Onefloortoanothefloor");


           // speechBox.SetText("Your new speech text");

        }
        else
        {
            MovetoMap();
        }

    }

}
