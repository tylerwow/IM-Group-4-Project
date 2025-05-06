using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSwitch : MonoBehaviour
{
    BoxCollider bc;

    public CameraManager cameraManager;

    void Start()
    {
        bc = GetComponent<BoxCollider>();           
    }

    void Update()
    {
        if (cameraManager.is3D)
        {
            bc.enabled = true;
        }       
        else
        {
            bc.enabled = false;
        }
    }
}
