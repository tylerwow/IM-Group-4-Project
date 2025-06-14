using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSwitch : MonoBehaviour
{
    //https://www.youtube.com/watch?v=yaQlRvHgIvE&t=37s

    public PlayerManager playerManager;
    public GameObject virtualCam;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")) {
            virtualCam.SetActive(true);
        }

        playerManager.UpdateRoomsList(gameObject.name);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player")) {
            virtualCam.SetActive(false);
        }
    }
}
