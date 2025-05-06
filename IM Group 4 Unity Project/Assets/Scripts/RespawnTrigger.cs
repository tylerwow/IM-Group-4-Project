using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
    public PlayerManager playerManager;

    void OnTriggerEnter(Collider other)
    {
        playerManager.RespawnPlayer();
    }
}
