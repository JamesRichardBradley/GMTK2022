using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider player)
    {
        if (player.name == "PlayerDie")
        {
            SceneManager.LoadScene("");
        }
    }
}
