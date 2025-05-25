using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggerBridge : MonoBehaviour
{
    public GameObject bridge;
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
                bridge.SetActive(true);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.E) && cameraManager.is3D)
            {
                audioSource.Play();
                bridge.SetActive(true);
            }
        }
    }
}
