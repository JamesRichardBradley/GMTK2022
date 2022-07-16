using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTrigger : MonoBehaviour, IDiceCheck<int>
{
    public int correctDieFace = 5;

    public Animator interactionObject;

    public bool Check(int dieFace)
    {
        return correctDieFace == dieFace;
    }

    public void Animate()
    {
        interactionObject.SetTrigger("Activate");
    }

    

    private void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent<PlayerManager>(out PlayerManager player))
        {
            if (Check(player.DieFacing()))
                Animate();

        }
    }

    
}
