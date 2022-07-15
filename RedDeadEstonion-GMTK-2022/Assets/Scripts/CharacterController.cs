using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 8f;

    Rigidbody m_rigidbody;
    Vector2 inputs;


    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        inputs.x = Input.GetAxis("Horizontal");
        inputs.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 moveDir = (transform.forward * inputs.y + transform.right * inputs.x) * speed;
        m_rigidbody.AddForce(new Vector3(moveDir.x, m_rigidbody.velocity.y, moveDir.z));    
    }
}
