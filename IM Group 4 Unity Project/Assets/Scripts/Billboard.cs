using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public CameraManager cameraManager;

    public GameObject camera3d;

    void Update() 
    {
        if (cameraManager.is3D)
        {
            transform.LookAt(camera3d.transform.position, Vector3.up);
        }
    }
}
