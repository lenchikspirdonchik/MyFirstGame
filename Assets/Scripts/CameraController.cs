using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 startPos;
    private Camera _camera; 
    private float targetPos;
    public float speed;
  private void Start()
    {
        _camera = GetComponent<Camera>();
    }

   
   private void Update()
    {
      
        if (Input.GetMouseButtonDown(0)) startPos = _camera.ScreenToViewportPoint(Input.mousePosition);
        else if (Input.GetMouseButton(0))
        {
            float positionX = _camera.ScreenToViewportPoint(Input.mousePosition).x - startPos.x;
            targetPos = transform.position.x - positionX;
        }
        transform.position =
            new Vector3(Mathf.Lerp(transform.position.x, targetPos, speed+Time.deltaTime), transform.position.y, transform.position.z);
    }
}
