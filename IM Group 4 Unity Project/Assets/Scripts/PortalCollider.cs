using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalCollider : MonoBehaviour
{
    void OnTriggerEnter() {
        if (SceneManager.GetActiveScene().buildIndex == 0) {
            SceneManager.LoadScene(1);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 1) {
            SceneManager.LoadScene(0);
        }
    }
}
