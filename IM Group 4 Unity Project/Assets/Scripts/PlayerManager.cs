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

    Vector3 lastPos;
    bool hasCollided;

    //Audio Clips
    public AudioClip walkSound;
    public AudioClip jumpSound;
    public AudioSource audioSource;

    public void Start()
    {
        t = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        c = GetComponent<Collider>();
        mr = GetComponent<MeshRenderer>();
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = walkSound;
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
        if (!cameraManager.is3D)
        {
            t.localScale = new Vector3(1.0f, 1.0f, 100.0f);

            mr.enabled = false;

            Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            rb.MovePosition(t.position + input * Time.fixedDeltaTime * speed);
        }
        if (cameraManager.is3D)
        {
            t.localScale = new Vector3(1.0f, 1.0f, 1.0f);

            mr.enabled = true;

            if (!hasCollided)
            {
                Vector3 input = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
                rb.MovePosition(t.position + input * Time.fixedDeltaTime * speed);

            }
            else
            {
                t.position = lastPos;
                rb.MovePosition(lastPos);
                hasCollided = false;
            }
        }

        collider2d.transform.position = new Vector3(t.position.x, t.position.y, -10.0f);

        if (Input.GetKey(KeyCode.Space) && isGrounded())
        {
            rb.AddForce(new Vector3(0.0f, jumpSpeed, 0.0f), ForceMode.Impulse);
            audioSource.clip = jumpSound;
            audioSource.Play();
        }

        lastPos = t.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall" && cameraManager.is3D)
        {
            hasCollided = true;
        }
    }

    bool isGrounded()
    {
        return rb.velocity.y == 0;
    }

    public void UpdateRoomsList(string roomName)
    {
        if (!roomList.Contains(roomName))
        {
            roomList.Add(roomName);
        }
    }

    public string lastRoomName()
    {
        return roomList[roomList.Count - 1];
    }

    public void RespawnPlayer()
    {
        GameObject respawnPos = GameObject.Find(lastRoomName() + "/Respawn Position");

        t.position = respawnPos.transform.position;
    }
}