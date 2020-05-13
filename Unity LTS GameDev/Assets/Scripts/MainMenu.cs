using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Base");
        Debug.Log("Play");
    }

    public void ControlsGame()
    {
        Debug.Log("Controls");
        SceneManager.LoadScene("Controls");

    }
    public void Cinematic()
    {
        SceneManager.LoadScene("Cinematic");
    }
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
