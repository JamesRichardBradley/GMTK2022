using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform target;
    Vector3 velocity;
    float yaw;
    float pitch;

    public Vector3 offset = new Vector3(0f, 3f, 5f);
    public float smoothDamp = 0.5f;
    public float smoothLook = 0.5f;
    public float sensitivity = 15f;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerMovement>().transform;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * sensitivity;
        pitch += Input.GetAxis("Mouse Y") * sensitivity;

        pitch = Mathf.Clamp(pitch, -45, 45);
        Quaternion input = Quaternion.Euler(pitch, yaw, 0);

        Quaternion targetRotation = Quaternion.LookRotation((target.transform.position + transform.forward) - transform.position);

        Quaternion overallRot = Quaternion.FromToRotation(targetRotation.eulerAngles, input.eulerAngles);

        // Smoothly rotate towards the target point.
        transform.rotation = Quaternion.Slerp(transform.rotation, overallRot, smoothLook * Time.deltaTime);


        Vector3 pos = (target.position + offset);
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smoothDamp);

    }
}
