using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TankController : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    private Joystick _joystick;

    private void Start()
    {
        _joystick = FindObjectOfType<Joystick>();
    }


    void FixedUpdate()
    {
        transform.Rotate(0, _joystick.Horizontal * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, _joystick.Vertical * Time.deltaTime * movementSpeed);


        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
    }
} 