using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    Transform t;
    Rigidbody rb;
    Collider c;
    public CameraManager cameraManager;
    public float speedFloat;

    public void Start()
    {
        t = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        c = GetComponent<Collider>();
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

        if (!cameraManager.is3D) {
            t.localScale = new Vector3(1.0f, 1.0f, 100.0f);
        }

        if (cameraManager.is3D) {
            t.localScale = new Vector3(1.0f, 1.0f, 1.0f);

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

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded()) {
            rb.AddForce(new Vector3(0.0f, 10.0f, 0.0f), ForceMode.Impulse);
        }
    }

    bool isGrounded() {
        return rb.velocity.y == 0;
    }
}