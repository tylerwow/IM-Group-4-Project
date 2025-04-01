using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    Transform t;
    public CameraManager cameraManager;
    public float speedFloat;

    public void Start()
    {
        t = GetComponent<Transform>();
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            t.Translate(new Vector3(-speedFloat, 0.0f, 0.0f) * speedFloat * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {   
            t.Translate(new Vector3(speedFloat, 0.0f, 0.0f) * speedFloat * Time.deltaTime);
        }

        if (!cameraManager.camIsOrthographic) {
            if (Input.GetKey(KeyCode.W))
            {
                t.Translate(new Vector3(0.0f, 0.0f, speedFloat) * speedFloat * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {   
                t.Translate(new Vector3(0.0f, 0.0f, -speedFloat) * speedFloat * Time.deltaTime);
            }
        }
    }
}
