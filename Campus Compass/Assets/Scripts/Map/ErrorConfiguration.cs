using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Drawing;

public class ErrorConfiguration : MonoBehaviour
{
    [SerializeField] public TMP_Dropdown locationFloorDropdown;
    [SerializeField] public TMP_Dropdown locationPlaceDropdown;

    [SerializeField] public TMP_Dropdown DestinationFloorDropdown;
    [SerializeField] public TMP_Dropdown DestinationPlaceDropdown;

    public TextMeshProUGUI text;

    private string pickedLocation;
    private string pickedDestination;

    private void OptionSelected()
    {
        string pickedLocationFloor = locationFloorDropdown.options[locationFloorDropdown.value].text;
        string pickedLocationPlace = locationPlaceDropdown.options[locationPlaceDropdown.value].text;
        pickedLocation  = pickedLocationFloor + " " + pickedLocationPlace;

        string pickedDestinationFloor = DestinationFloorDropdown.options[DestinationFloorDropdown.value].text;
        string pickedDestinationPlace = DestinationPlaceDropdown.options[DestinationPlaceDropdown.value].text;
        pickedDestination = pickedDestinationFloor + " " + pickedDestinationPlace;
    }

    public void checkError()
    {
        OptionSelected();
        if ( pickedLocation == pickedDestination)
        {
            text.color = UnityEngine.Color.white;

        }
    }

}
