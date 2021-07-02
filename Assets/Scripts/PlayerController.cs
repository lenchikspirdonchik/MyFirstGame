using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public float jumpForse;
    protected Joystick joystick;
    protected JoyButton joyButton;
    protected bool jump;
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joyButton = FindObjectOfType<JoyButton>();
    }

 
     void FixedUpdate()
     {
         rb.velocity = new Vector3(joystick.Horizontal * 10f,
             rb.velocity.y,
             joystick.Vertical * 10f);
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

         if (!jump && joyButton.isPressed)
         {
             jump = true;
             rb.velocity = Vector3.up * 10f;
         }

         if (jump && !joyButton.isPressed)
         {
             jump = false;
         }
     }
}
