using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDiceCheck<T>
{
    public bool Check(int dieFace);
}
