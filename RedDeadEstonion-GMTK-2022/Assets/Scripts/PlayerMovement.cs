using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    Vector3 targetPos;

    public float speed = 8f;
    
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
    }

    private void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, targetPos) > 2)
            rb.AddForce(targetPos.normalized * speed);

    }
}
