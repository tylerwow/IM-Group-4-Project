using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTrigger : MonoBehaviour
{
    public GameObject bridge;

    void OnCollisionEnter(Collision collision)
    {
        bridge.SetActive(true);
    }
}
