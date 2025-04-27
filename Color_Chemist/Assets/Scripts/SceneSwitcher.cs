using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void MainMenuScene(string name)
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void MainLevelScene(string name)
    {
        SceneManager.LoadScene("Main Level");
    }

    public void HowToPlayScene(string name)
    {
        SceneManager.LoadScene("How to Play");
    }

    public void ColorKeyScene(string name)
    {
        SceneManager.LoadScene("Color Key");
    }

    public void CreditsScene(string name)
    {
        SceneManager.LoadScene("Credits");
    }


}
