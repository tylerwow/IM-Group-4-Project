using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    Transform t;
    Quaternion startRotation;

    public CameraManager cameraManager;

    public GameObject camera3d;

    void Start()
    {
        t = GetComponent<Transform>();

        startRotation = t.transform.rotation;
    }

    void Update()
    {
        if (cameraManager.is3D)
        {
            transform.LookAt(camera3d.transform.position, Vector3.up);
        }
        else
        {
            transform.rotation = startRotation;
        }
    }
}
