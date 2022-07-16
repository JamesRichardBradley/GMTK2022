using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTrigger : MonoBehaviour, IDiceCheck<int>
{
    public int correctDieFace = 5;

    public bool Check(int dieFace)
    {
        return correctDieFace == dieFace;
    }

    public void Animate()
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        if(TryGetComponent<PlayerManager>(out PlayerManager player))
        {
            if (Check(player.DieFacing()))
                Animate();

        }
    }
}
