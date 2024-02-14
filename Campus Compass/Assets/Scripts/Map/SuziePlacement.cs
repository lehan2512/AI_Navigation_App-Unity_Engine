using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class SuziePlacement : MonoBehaviour
{
    public Camera arCamera;
    private Transform arCameraTransform;
    public int sceneNo;
    public bool exit;
    public Button YesButton;
    public Button NoButton;
    private Vector3 initialPosition;


    void Start()
    {
        // Find the AR camera in the scene
        arCamera = Camera.main;
        arCameraTransform = arCamera.transform;
        initialPosition = transform.position;
    }

    void Update()
    {
        if (sceneNo == 0)
        {
            SuzieLocation(5f, 0.3f, 0.2f);
        }
        else if (sceneNo == 1)
        {
            SuzieLocation(2f, 0.2f, 0.2f);
        }

    }

    private void SuzieLocation(float distance, float down, float left)
    {

        GetComponent<Animator>().applyRootMotion = false;



        // Make the object always face the AR camera
        Quaternion cameraRotation = Quaternion.LookRotation(-arCameraTransform.forward, Vector3.up);


        // Place the object a certain distance in front of the camera

        transform.position = arCameraTransform.position + arCameraTransform.forward * distance;

        // Adjust position to move down and left
        if (exit == false)
        {
            transform.position -= arCameraTransform.up * down; // Move down
            transform.position -= arCameraTransform.right * left; // Move left
            //transform.position = initialPosition;

            if (sceneNo == 2)
            {
                Image yesImage = YesButton.GetComponent<Image>();
                Image noImage = NoButton.GetComponent<Image>();

                yesImage.enabled = false;
                noImage.enabled = false;
            }
        }

      
    }

    public void PressedExit()
    {
        Image yesImage = YesButton.GetComponent<Image>();
        Image noImage = NoButton.GetComponent<Image>();

        yesImage.enabled = true;
        noImage.enabled = true;


        Vector3 screenCenter = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);

        // Convert screen center position to world space
        Vector3 worldCenter = Camera.main.ScreenToWorldPoint(screenCenter);

        // Set the character's position to the calculated world space center position
        transform.position = worldCenter;

        transform.localScale *= 1.5f;

    }
}


