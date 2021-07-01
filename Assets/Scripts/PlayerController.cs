using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public float jumpForse;
    void Start()
    {
     
    }

    void FixedUpdate()
    {
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
       
    }
}
