using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldController : MonoBehaviour
{
    public float speed = 2.5f;
    public GameObject otherObject;
   private Animator otherAnimator;
   public WorldBuilder worldBuilder;
   public static WorldController instance;
   public float minZ = -3;
   public Text txtScore;
   public float score = 0;

   public delegate void TryToDelAddPlatform();
   public event TryToDelAddPlatform onPlatformMovement;

   private void Awake()
   {
       if (WorldController.instance != null)
       {
           Destroy(gameObject);
           return;
       }

       WorldController.instance = this;
       //DontDestroyOnLoad(gameObject);
   }

   private void OnDestroy()
   {
       WorldController.instance = null;
   }

   void Start()
    {
        otherAnimator = otherObject.GetComponent<Animator>();
        StartCoroutine("onPlatformMovementCour");
        StartCoroutine("Move");
    }


    void Update()
    {
/*if (!otherAnimator.GetBool("dead") && otherAnimator.GetBool("run"))
        transform.position = transform.position + Vector3.back * speed *Time.deltaTime;*/


    }

    IEnumerator onPlatformMovementCour()
    {yield return new WaitForSeconds(3.8f);
        while (!otherAnimator.GetBool("dead"))
        {
            yield return new WaitForSeconds(1f);
            speed+=0.1f;
            score += 1*speed/5;
            txtScore.text = String.Format("{0:F00}", score);
            if (onPlatformMovement != null) onPlatformMovement();
        }
    }
    
    IEnumerator Move()
    {
        yield return new WaitForSeconds(3.8f);
        while (!otherAnimator.GetBool("dead"))
        {
            yield return new WaitForFixedUpdate();
            transform.position = transform.position + Vector3.back * speed *Time.deltaTime;
        }
    }

 
}
