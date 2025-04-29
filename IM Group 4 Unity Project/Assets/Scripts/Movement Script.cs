using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    Transform t;
    Rigidbody rb;
    Collider c;
    public CameraManager cameraManager;
    public float speed;
    public float jumpSpeed;

    public void Start()
    {
        t = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        c = GetComponent<Collider>();
    }

    public void Update()
    {
        if (!cameraManager.is3D) {
            if (Input.GetKey(KeyCode.A))
            {
                t.Translate(new Vector3(-speed, 0.0f, 0.0f) * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {   
                t.Translate(new Vector3(speed, 0.0f, 0.0f) * speed * Time.deltaTime);
            }

            t.localScale = new Vector3(1.0f, 1.0f, 100.0f);
        }

        if (cameraManager.is3D) {
            t.localScale = new Vector3(1.0f, 1.0f, 1.0f);

            if (Input.GetKey(KeyCode.W))
            {
                t.Translate(new Vector3(speed, 0.0f, 0.0f) * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {   
                t.Translate(new Vector3(-speed, 0.0f, 0.0f) * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                t.Translate(new Vector3(0.0f, 0.0f, speed) * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {   
                t.Translate(new Vector3(0.0f, 0.0f, -speed) * speed * Time.deltaTime);
            }
        }
    }

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded()) {
            rb.AddForce(new Vector3(0.0f, jumpSpeed, 0.0f), ForceMode.Impulse);
        }
    }

    bool isGrounded() {
        return rb.velocity.y == 0;
    }
}