using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public Transform endPoint;

    private void Start()
    {
        WorldController.instance.onPlatformMovement += TryToDelAddPlatform;
    }

    private void TryToDelAddPlatform()
    {
        if (transform.position.z < WorldController.instance.minZ)
        {
            WorldController.instance.worldBuilder.createPlatform();
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        WorldController.instance.onPlatformMovement -= TryToDelAddPlatform;
    }
}
