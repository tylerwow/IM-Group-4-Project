using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    Transform t;
    Vector3 doorClosedPos;
    Vector3 doorOpenPos;

    public bool isOpen;

    void Start()
    {
        t = GetComponent<Transform>();
        doorClosedPos = t.position;
        doorOpenPos = t.position + new Vector3(0.0f, 5.0f, 0.0f);
    }

    void FixedUpdate()
    {
        if (isOpen)
        {
            t.position = Vector3.MoveTowards(t.position, doorOpenPos, 3 * Time.deltaTime);
        }
        else
        {
            t.position = Vector3.MoveTowards(t.position, doorClosedPos, 3 * Time.deltaTime);
        }
    }
}
