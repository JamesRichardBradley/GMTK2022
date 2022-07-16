using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourSelect : MonoBehaviour
{
    public GameObject[] chips;
    private int selection;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var chip in chips)
        {
            selection = Random.Range(0, 10);
            var chipRenderer = chip.GetComponent<Renderer>();

            if (selection <= 5)
            {
                chipRenderer.material.SetColor("_BaseColor", Color.red);
            }
            else
            {
             chipRenderer.material.SetColor("_BaseColor", Color.black);
            }
        }
    }
}
