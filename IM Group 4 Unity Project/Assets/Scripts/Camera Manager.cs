using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public bool camIsOrthographic;

    // Start is called before the first frame update
    void Start()
    {
        camIsOrthographic = true;    
    }

    // Update is called once per frame
    void Update()
    {
        if (camIsOrthographic) {
            Camera.main.orthographic = true;
        }
        else {
            Camera.main.orthographic = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && camIsOrthographic)
        {
            camIsOrthographic = false;
        }
        else if (Input.GetKeyDown(KeyCode.E) && !camIsOrthographic)
        {
            camIsOrthographic = true;
        }
    }
}
