using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadInfoScene()
    {
        UnityEngine.Debug.Log("Switching to Info Scene...");
        SceneManager.LoadScene("InfoScene");
    }

    public void LoadLevel1()
    {
        UnityEngine.Debug.Log("Switching to Level 1...");
        SceneManager.LoadScene("Level1");
    }

    public void LoadStartMenuScene()
    {
        UnityEngine.Debug.Log("Switching back to Start Menu...");
        SceneManager.LoadScene("StartMenuScene");
    }
}