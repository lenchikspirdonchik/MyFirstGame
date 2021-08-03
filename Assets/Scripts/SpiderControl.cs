using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderControl : MonoBehaviour
{
    private Animator _animator;
    private Joystick _joystick;
    private JoyButton _joyButton;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _joystick = FindObjectOfType<Joystick>();
        _joyButton = FindObjectOfType<JoyButton>();
    }

    void Update()
    {
        if (_animator != null)
        {
            // float forward = Input.GetAxis("Vertical");
            // float right = Input.GetAxis("Horizontal");
            float forward = _joystick.Vertical;
            float right = _joystick.Horizontal;
            bool isattack = _joyButton.isPressed;

            _animator.SetFloat("forward", forward);
            _animator.SetFloat("right", right);
            if (isattack) _animator.SetTrigger("attack");
        }
    }
}