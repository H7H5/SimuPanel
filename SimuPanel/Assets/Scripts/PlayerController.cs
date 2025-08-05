using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Transform cameraTransform; // посилання на об'єкт камери
    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        // Ігноруємо вертикальну вісь (Y), щоб не було руху вгору/вниз
        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        // Формуємо напрямок руху
        Vector3 moveDir = forward * verticalInput + right * horizontalInput;

        // Додати вертикальний рух (вгору/вниз)
        if (Input.GetKey(KeyCode.E))
        {
            moveDir += Vector3.up;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            moveDir += Vector3.down;
        }

        controller.Move(moveDir * moveSpeed * Time.deltaTime);
    }
}
