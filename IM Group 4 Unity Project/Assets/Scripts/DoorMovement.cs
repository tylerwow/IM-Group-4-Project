using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    Transform t;
    Vector3 doorClosedPos;
    Vector3 doorOpenPos;
    AudioSource audioSource;
    bool isAudioPlaying;
    public bool isOpen;

    void Start()
    {
        t = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
        isAudioPlaying = false;
        doorClosedPos = t.position;
        doorOpenPos = t.position + new Vector3(0.0f, 5.0f, 0.0f);
    }

    void FixedUpdate()
    {
        if (isOpen)
        {
            t.position = Vector3.MoveTowards(t.position, doorOpenPos, 3 * Time.deltaTime);

            if (!isAudioPlaying)
            {
                audioSource.Play();
                isAudioPlaying = true;
            }
        }
        else
        {
            t.position = Vector3.MoveTowards(t.position, doorClosedPos, 3 * Time.deltaTime);
        }
    }
}
