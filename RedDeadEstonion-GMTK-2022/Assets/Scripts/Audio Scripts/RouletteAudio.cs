using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteAudio : MonoBehaviour
{
    [SerializeField] AudioSource rouletteimpact;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Sound");
            rouletteimpact.Play();
        }
    }
}
