using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    Vector3 targetPos;

    public float speed = 8f;
    public float jumpForce;
    private bool isGrounded;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           RaycastHit hit;
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                targetPos = hit.point;
            }
        }

        if(isGrounded && Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, targetPos) > 2)
            rb.AddForce(targetPos.normalized * speed);

    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded=false;
    }
}
