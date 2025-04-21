using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    //public bool camIsOrthographic;

    public GameObject player;
    public Camera cam3D;
    public Camera cam2D;

    public bool is3D;

    // Start is called before the first frame update
    void Start()
    {
        cam3D.enabled = false;
        cam2D.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cam3D.enabled = !cam3D.enabled;
            cam2D.enabled = !cam2D.enabled;
        }

        if (cam3D.enabled) {
            is3D = true;
        }
        else {
            is3D = false;
        }

        cam2D.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 500.0f);
    }
}
