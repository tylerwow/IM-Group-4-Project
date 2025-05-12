using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggerTemp : MonoBehaviour
{
    public WhiteButtonTrigger whiteButtonTrigger;
    public GameObject door;
    public CameraManager cameraManager;
    public bool is3dOnly;

    void OnTriggerStay(Collider other)
    {
        if (!is3dOnly)
        {
            if (Input.GetKey(KeyCode.E))
            {
                door.SetActive(false);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.E) && cameraManager.is3D)
            {
                door.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (!whiteButtonTrigger.activated)
        {
            door.SetActive(true);
        }
    }
}
