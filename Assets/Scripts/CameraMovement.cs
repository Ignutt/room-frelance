using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Zoom")]
    [SerializeField] private float minZoom;
    [SerializeField] private float maxZoom;
    [SerializeField] private float speedZoom = 5;

    [Header("Rotations")] 
    [SerializeField] private float sensitivityX = 4;
    [SerializeField] private bool revertX = true;
    [SerializeField] private float sensitivityY = 4;
    [SerializeField] private bool revertY = true;
    
    private Camera _camera;

    private void Awake()
    {
        _camera = GetComponent<Camera>();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float zoomInput = Input.GetAxis("Mouse ScrollWheel") * speedZoom;
        _camera.fieldOfView = Mathf.Clamp(_camera.fieldOfView - zoomInput, minZoom, maxZoom);

        float rotationX = Input.GetAxis("Mouse Y") * sensitivityY * (revertY ? 1 : -1);
        float rotationY = Input.GetAxis("Mouse X") * sensitivityX * (revertX ? 1 : -1);

        rotationX += transform.eulerAngles.x;
        rotationY += transform.eulerAngles.y;

        rotationX = Mathf.Clamp(WrapAngle(rotationX), -90, 90);
        rotationY = Mathf.Clamp(WrapAngle(rotationY), -101, 18);
        transform.eulerAngles = new Vector3(rotationX, rotationY, 0);
        
    }
    
    private static float WrapAngle(float angle)
    {
        angle%=360;
        if(angle >180)
            return angle - 360;
 
        return angle;
    }
 
    private static float UnwrapAngle(float angle)
    {
        if(angle >=0)
            return angle;
 
        angle = -angle%360;
 
        return 360-angle;
    }
}
