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
        }
    }
}


