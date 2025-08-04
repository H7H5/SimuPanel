using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitBreaker : MonoBehaviour
{
    private bool isOn = false;
    private Renderer rend;

    public Color onColor = Color.green;
    public Color offColor = Color.red;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        SetState(isOn);
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        isOn = !isOn;
        SetState(isOn);
    }
    void Update()
    {
        
    }

    void SetState(bool state)
    {
        if (state)
        {
            rend.material.color = onColor;
            Debug.Log("Автомат увімкнено");
        }
        else
        {
            rend.material.color = offColor;
            Debug.Log("Автомат вимкнено");
        }
    }
}
