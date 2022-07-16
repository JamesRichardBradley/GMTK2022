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
        float distToTarget = Vector3.Distance(transform.position, targetPos);

        if (distToTarget > 2)
        {
            Vector3 moveDir = targetPos - transform.position;

            rb.AddForce(moveDir.normalized * speed, ForceMode.Force);
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded=false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(targetPos, 1f);
        Gizmos.DrawLine(transform.position, targetPos);
    }
}
