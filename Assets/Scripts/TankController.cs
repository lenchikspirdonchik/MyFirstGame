using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TankController : MonoBehaviour
{
    public Button btnUp, btnDown, btnRight, btnLeft;
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;

    void Update()
    {

        btnRight.onClick.AddListener(delegate { transform.Rotate(0, 1 * Time.deltaTime * rotationSpeed, 0); });
        btnLeft.onClick.AddListener(delegate { transform.Rotate(0, -1 * Time.deltaTime * rotationSpeed, 0); });
        btnUp.onClick.AddListener(delegate { transform.Translate(0, 0, 1 * Time.deltaTime * movementSpeed); });
        btnDown.onClick.AddListener(delegate { transform.Translate(0, 0, -1 * Time.deltaTime * movementSpeed); });
    }

/*
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
    }*/
}