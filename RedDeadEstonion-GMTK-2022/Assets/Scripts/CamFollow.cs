using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    CameraController camController;

    private void Start()
    {
        camController = FindObjectOfType<CameraController>();
    }

    void LateUpdate()
    {

        Vector3 pos = (camController.target.position + camController.offset);
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref camController.velocity, camController.smoothDamp);


    }
}
