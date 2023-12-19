using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NameDisplayManager : MonoBehaviour
{
    public TextMeshProUGUI display_name;

    public void Awake()
    {
        display_name.text = CheckInputField.scene1.user_name;
    }
}
