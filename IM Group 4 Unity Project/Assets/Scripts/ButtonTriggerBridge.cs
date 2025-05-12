using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggerBridge : MonoBehaviour
{
    public GameObject bridge;
    public CameraManager cameraManager;
    public bool is3dOnly;

    void OnTriggerStay(Collider other)
    {
        if (!is3dOnly)
        {
            if (Input.GetKey(KeyCode.E))
            {
                bridge.SetActive(true);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.E) && cameraManager.is3D)
            {
                bridge.SetActive(true);
            }
        }
    }
}
