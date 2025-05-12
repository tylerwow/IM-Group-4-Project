using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSwitch : MonoBehaviour
{
    BoxCollider bc;

    public CameraManager cameraManager;

    public bool is2dOnly = false;

    void Start()
    {
        bc = GetComponent<BoxCollider>();           
    }

    void Update()
    {
        if (is2dOnly && !cameraManager.is3D)
        {
            bc.enabled = true;
        }
        else if (is2dOnly && cameraManager.is3D)
        {
            bc.enabled = false;
        }
        else if (!is2dOnly && cameraManager.is3D)
        {
            bc.enabled = true;
        }       
        else if (!is2dOnly && !cameraManager.is3D)
        {
            bc.enabled = false;
        }
    }
}
