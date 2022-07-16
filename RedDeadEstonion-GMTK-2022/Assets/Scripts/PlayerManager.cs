using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{


    int DieFacing()
    {
        int die = 0;

        float forwardAngle = Vector3.Angle(transform.forward,Vector3.up);
        if(forwardAngle < 20)
            die = 1;
        if (forwardAngle > 160 && forwardAngle < 200)
            die = 5;

        float rightAngle = Vector3.Angle(transform.right, Vector3.up);
        if (rightAngle < 20)
            die = 2;
        if (rightAngle > 160 && rightAngle < 200)
            die = 4;

        float upAngle = Vector3.Angle(transform.up, Vector3.up);
        if (upAngle < 20)
            die = 6;
        if (upAngle > 160 && upAngle < 200)
            die = 3;

        return die;
    }

    private void OnCollisionStay(Collision collision)
    {
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.right * 3);

        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, transform.up * 3);

        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, transform.forward * 3);

        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, Vector3.up * 3);

    }
}
