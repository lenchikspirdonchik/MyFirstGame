using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public float jumpForse;
    private Joystick _joystick;
    private JoyButton _joyButton;
    private bool _jump;
    
  
    
    void Start()
    {
        _joystick = FindObjectOfType<Joystick>();
        _joyButton = FindObjectOfType<JoyButton>();
    }

 
     void FixedUpdate()
     {
       rb.AddForce(new Vector3(_joystick.Horizontal *  (force * Time.fixedDeltaTime),
             rb.velocity.y,
             _joystick.Vertical* (force * Time.fixedDeltaTime)));
         if (Input.GetKey(KeyCode.W))
             rb.AddForce(Vector3.forward * (force * Time.fixedDeltaTime));
       
         if (Input.GetKey(KeyCode.S))
             rb.AddForce(Vector3.forward * (-force * Time.fixedDeltaTime));
         
         if (Input.GetKey(KeyCode.D))
             rb.AddForce(Vector3.right * (force * Time.fixedDeltaTime));
         
         if (Input.GetKey(KeyCode.A))
             rb.AddForce(Vector3.right * (-force * Time.fixedDeltaTime));
         
         if (Input.GetKeyDown(KeyCode.Space))
             rb.AddForce(Vector3.up * (jumpForse * Time.fixedDeltaTime));

         if (!_jump && _joyButton.isPressed)
         {
             _jump = true;
            rb.AddForce(Vector3.up * (jumpForse * Time.fixedDeltaTime));
         }

         if (_jump && !_joyButton.isPressed) 
             _jump = false;
         
     }
}
