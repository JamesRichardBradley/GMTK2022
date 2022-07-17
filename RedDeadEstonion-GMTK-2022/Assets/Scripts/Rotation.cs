using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 1.0f;

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
