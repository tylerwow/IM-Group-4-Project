using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggerTemp : MonoBehaviour
{
    public WhiteButtonTrigger whiteButtonTrigger;
    public DoorMovement doorMovement;
    public CameraManager cameraManager;
    public bool is3dOnly;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerStay(Collider other)
    {
        if (!is3dOnly)
        {
            if (Input.GetKey(KeyCode.E))
            {
                audioSource.Play();
                doorMovement.isOpen = true;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.E) && cameraManager.is3D)
            {
                audioSource.Play();
                doorMovement.isOpen = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (!whiteButtonTrigger.activated)
        {
            doorMovement.isOpen = false;
        }
    }
}
