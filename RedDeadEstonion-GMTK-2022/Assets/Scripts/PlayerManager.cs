using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   

    int DieFacing()
    {
        int die = 0;

        float forwardAngle = Vector3.Angle(transform.forward,Vector3.up);
        if(forwardAngle > 340 || forwardAngle < 20)
            die = 1;
        if (forwardAngle > 160 || forwardAngle < 200)
            die = 5;

        return die;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(DieFacing());
    }
}