using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownOptions : MonoBehaviour
{
    [SerializeField] public TMP_Dropdown floorDropdown;
    [SerializeField] public TMP_Dropdown PlaceDropdown;

    private List<TMP_Dropdown.OptionData> AvailableOptions = new List<TMP_Dropdown.OptionData>();


    private void GroundOptions()
    {
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Main-Entrance", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Student Well-being office", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Lounge Area", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Washrooms", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Staircase", null));

        PlaceDropdown.options = AvailableOptions;
        PlaceDropdown.RefreshShownValue();
    }

    private void FirstOptions()
    {
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Entrance", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Library", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Student Ambassador", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Staff Office", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Washrooms", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Student Ambassador", null));


        PlaceDropdown.options = AvailableOptions;
        PlaceDropdown.RefreshShownValue();
    }

    private void SecondOptions()
    {
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Entrance", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Class 201", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Class 202", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Class 203", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Class 204", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Class 205", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Class 206", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Study Area", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Washrooms", null));


        PlaceDropdown.options = AvailableOptions;
        PlaceDropdown.RefreshShownValue();
    }

    private void ThirdOptions()
    {
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Entrance", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Lost And Found", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Chemistry Lab", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Computer Lab 01", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Computer Lab 02", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Study Area", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Washrooms", null));


        PlaceDropdown.options = AvailableOptions;
        PlaceDropdown.RefreshShownValue();
    }

    private void FourthOptions()
    {
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Entrance", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Class 401", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Class 402", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Class 403", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Class 404", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Study Area", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Washrooms", null));


        PlaceDropdown.options = AvailableOptions;
        PlaceDropdown.RefreshShownValue();
    }

    private void RooftopOptions()
    {
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Entrance", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Pool Table", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Student Lounge Area", null));
        AvailableOptions.Add(new TMP_Dropdown.OptionData("Cafeteria", null));


        PlaceDropdown.options = AvailableOptions;
        PlaceDropdown.RefreshShownValue();
    }

    public void FloorSelected()
    {
        int pickedFloor = floorDropdown.value;

        PlaceDropdown.ClearOptions();

        if (pickedFloor == 0)
        {
            GroundOptions();
        }
        else if(pickedFloor == 1) 
        {
            FirstOptions();
        }
        else if (pickedFloor == 2)
        {
            SecondOptions();
        }
        else if (pickedFloor == 3)
        {
            ThirdOptions();
        }
        else if (pickedFloor == 4)
        {
            FourthOptions();    
        }
        else if (pickedFloor == 5)
        {
            RooftopOptions();
        }

        PlaceDropdown.RefreshShownValue();
    }
}
