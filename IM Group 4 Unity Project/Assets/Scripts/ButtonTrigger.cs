using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public DoorMovement doorMovement;
    public CameraManager cameraManager;
    public bool is3dOnly;

    void OnTriggerStay(Collider other)
    {
        if (!is3dOnly)
        {
            if (Input.GetKey(KeyCode.E))
            {
                doorMovement.isOpen = true;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.E) && cameraManager.is3D)
            {
                doorMovement.isOpen = true;
            }
        }
    }
}
