using UnityEngine;

public class Booster : MonoBehaviour
{
   public float force;
   
   private void OnTriggerEnter(Collider other)
   {
      Rigidbody playerRb = other.GetComponent<Rigidbody>();
      playerRb.AddForce(transform.up * force);


   }
}
