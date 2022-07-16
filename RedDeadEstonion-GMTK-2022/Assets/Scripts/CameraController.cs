using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 velocity;
    float yaw;
    float pitch;
    private float desiredRot;

    public Vector3 offset = new Vector3(0f, 3f, 5f);
    public float smoothDamp = 0.5f;
    public float smoothLook = 0.5f;
    public float sensitivity = 15f;
    public float damping = 10;


    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerMovement>().transform;
        Cursor.lockState = CursorLockMode.Confined;

    }

    // Update is called once per frame
    void LateUpdate()
    {


        Quaternion targetRotation = Quaternion.LookRotation(target.transform.position - transform.position);

        // Smoothly rotate towards the target point.
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothLook * Time.deltaTime);



        float degreeTarget = Input.GetAxis("Mouse X") * sensitivity;
        desiredRot = Mathf.LerpAngle(0,degreeTarget, damping * Time.deltaTime);
        transform.RotateAround(target.position, Vector3.up, desiredRot);

        float z = Mathf.Clamp(transform.position.z, 2f, offset.z);

    }
}
