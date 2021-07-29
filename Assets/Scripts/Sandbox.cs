using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Sandbox : MonoBehaviour
{
    public FixedTouchField touchField;
    private RigidbodyFirstPersonController fps;

    private void Start()
    {
        fps = GetComponent<RigidbodyFirstPersonController>();
    }

    private void Update()
    {
        fps.mouseLook.LookAxis = touchField.TouchDist;
    }
}
