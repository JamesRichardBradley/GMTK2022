using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   
    public float forwardAngle;

    private void Update()
    {
        forwardAngle = Vector3.Angle(transform.forward, Vector3.up);

    }

    int DieFacing()
    {
        int die = 0;

        forwardAngle = Vector3.Angle(transform.forward,Vector3.up);
        if(forwardAngle < 20)
            die = 1;
        if (forwardAngle > 160 && forwardAngle < 200)
            die = 5;

        return die;
    }

    private void OnCollisionStay(Collision collision)
    {
        print(DieFacing());
    }
}
