using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform target;
    Vector3 velocity;

    public Vector3 offset = new Vector3(0f, 3f, 5f);
    public float smoothDamp = 0.5f;
    public float smoothLook = 0.5f;
    public float sensitivity = 15f;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerMovement>().transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * sensitivity;



        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref velocity, smoothDamp);

        var targetRotation = Quaternion.LookRotation((target.transform.position) - transform.position);

        // Smoothly rotate towards the target point.
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothLook * Time.deltaTime);
    }
}
