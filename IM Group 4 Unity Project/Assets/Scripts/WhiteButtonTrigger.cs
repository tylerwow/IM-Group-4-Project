using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteButtonTrigger : MonoBehaviour
{
    public bool is3dOnly;
    public CameraManager cameraManager;

    public bool activated;

    void OnTriggerStay(Collider other)
    {
        if (!is3dOnly)
        {
            if (Input.GetKey(KeyCode.E))
            {
                activated = true;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.E) && cameraManager.is3D)
            {
                activated = true;
            }
        }
    }
}
