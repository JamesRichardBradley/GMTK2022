using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string mainLevel = "SampleScene";
    private string mainMenu = "MainMenu";

    public void StartGame()
    {
        SceneManager.LoadScene(mainLevel);
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void CloseButton()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("CreditsMenu");
    }

    public void OpenControlls()
    {
        SceneManager.LoadScene("ControllsMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
