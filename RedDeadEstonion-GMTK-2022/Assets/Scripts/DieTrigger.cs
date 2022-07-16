using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTrigger : MonoBehaviour
{
    public int correctDieFace = 5;



    public bool Check(int dieFace)
    {
        return correctDieFace == dieFace;
    }
}
