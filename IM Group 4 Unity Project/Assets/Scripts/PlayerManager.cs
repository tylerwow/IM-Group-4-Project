using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Transform t;
    Rigidbody rb;
    Collider c;
    MeshRenderer mr;
    public CameraManager cameraManager;
    public GameObject collider2d;
    public float speed;
    public float jumpSpeed;
    List<string> roomList = new List<string>();
    public int roomCount;

    public void Start()
    {
        t = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        c = GetComponent<Collider>();
        mr = GetComponent<MeshRenderer>();
    }

    public void Update()
    {
        roomCount = roomList.Count;

        if (Input.GetKeyDown(KeyCode.R))
        {
            RespawnPlayer();
        }
    }

    public void FixedUpdate()
    {
        if (!cameraManager.is3D) {
            t.localScale = new Vector3(1.0f, 1.0f, 100.0f);

            mr.enabled = false;
            
            if (Input.GetKey(KeyCode.A))
            {
                t.Translate(new Vector3(-speed, 0.0f, 0.0f) * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {   
                t.Translate(new Vector3(speed, 0.0f, 0.0f) * speed * Time.deltaTime);
            }
        }

        if (cameraManager.is3D) {
            t.localScale = new Vector3(1.0f, 1.0f, 1.0f);

            mr.enabled = true;

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

        collider2d.transform.position = new Vector3(t.position.x, t.position.y, -10.0f);

        if (Input.GetKey(KeyCode.Space) && isGrounded()) {
            rb.AddForce(new Vector3(0.0f, jumpSpeed, 0.0f), ForceMode.Impulse);
        }
    }

    bool isGrounded()
    {
        return rb.velocity.y == 0;
    }

    public void UpdateRoomsList(string roomName)
    {
        if (!roomList.Contains(roomName)) {
            roomList.Add(roomName);
        }
    }

    public string lastRoomName() {
        return roomList[roomList.Count - 1];
    }

    public void RespawnPlayer()
    {
        GameObject respawnPos = GameObject.Find(lastRoomName() + "/Respawn Position");
        
        t.position = respawnPos.transform.position;
    }
}