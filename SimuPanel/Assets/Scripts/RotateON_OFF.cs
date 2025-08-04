using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateON_OFF : MonoBehaviour
{
    private bool isOn = false;

    private void Start()
    {
        ApplyRotation(isOn);
    }

    private void OnMouseDown()
    {
        isOn = !isOn;
        ApplyRotation(isOn);
        Debug.Log(isOn ? "Увімкнено" : "Вимкнено");
    }

    private void ApplyRotation(bool state)
    {
        float angleX = state ? -166f : -88f;

        // Встановлюємо поворот напряму через кватерніон
        transform.localRotation = Quaternion.Euler(angleX, 0f, 0f);
    }

}
