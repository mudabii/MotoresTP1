using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 5.0f; 
    public float height = 2.0f; 
    public float rotationSpeed = 3.0f; 

    private float currentX = 0.0f;
    private float currentY = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void LateUpdate()
    {

        currentX += Input.GetAxis("Mouse X") * rotationSpeed;
        currentY -= Input.GetAxis("Mouse Y") * rotationSpeed;

        currentY = Mathf.Clamp(currentY, -10, 60);

        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);

        Vector3 negDistance = new Vector3(0.0f, height, -distance);
        Vector3 position = rotation * negDistance + target.position;

        transform.rotation = rotation;
        transform.position = position;
    }
}
