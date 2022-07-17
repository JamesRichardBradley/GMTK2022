using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteAudioTrigger : MonoBehaviour
{
    [SerializeField] AudioSource rouletteImpact;

    // Start is called before the first frame update
    void Start()
    {
        rouletteImpact = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.tag == "Player")
        {
            rouletteImpact.Play();
        }
    }
}
