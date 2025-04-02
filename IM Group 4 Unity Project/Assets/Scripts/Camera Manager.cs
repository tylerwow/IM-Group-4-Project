using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    //public bool camIsOrthographic;

    [SerializeField] private Camera cam3D;
    [SerializeField] private Camera cam2D;

    public bool is3D;

    // Start is called before the first frame update
    void Start()
    {
        //camIsOrthographic = true;

        cam3D.enabled = false;
        cam2D.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        /**
        if (camIsOrthographic) {
            Camera.main.orthographic = true;
        }
        else {
            Camera.main.orthographic = false;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            camIsOrthographic = !camIsOrthographic;
        }
        */

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
    }
}
