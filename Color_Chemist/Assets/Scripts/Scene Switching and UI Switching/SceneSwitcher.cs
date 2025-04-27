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
    public void LevelSelectScene(string name)
    {
        SceneManager.LoadScene("Level Select");
    }

    public void Level1Scene(string name)
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Level2Scene(string name)
    {
        SceneManager.LoadScene("Level 2");
    }

    public void Level3Scene(string name)
    {
        SceneManager.LoadScene("Level 3");
    }

    public void Level4Scene(string name)
    {
        SceneManager.LoadScene("Level 4");
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
