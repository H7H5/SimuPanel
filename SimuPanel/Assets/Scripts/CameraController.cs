using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 2.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;
    private bool isInteracting = false;
    void Start()
    {
        //Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;
        LockCursor(true);
    }

    void Update()
    {
        // Перемикання режиму пробілом
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isInteracting = !isInteracting;
            LockCursor(!isInteracting);
        }

        if (!isInteracting)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            rotationX -= mouseY;
            rotationX = Mathf.Clamp(rotationX, -90f, 90f);

            rotationY += mouseX;

            transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);
        }
    }


    void LockCursor(bool lockCursor)
    {
        Cursor.lockState = lockCursor ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !lockCursor;
    }
}
