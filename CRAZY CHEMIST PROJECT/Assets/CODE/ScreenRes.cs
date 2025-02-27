using UnityEngine;
using UnityEngine.SceneManagement;


public class ScreenRes : MonoBehaviour
{
    void Start()
    {
        ApplyScreenOrientation();
    }

    void ApplyScreenOrientation()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "StartMenuScene")
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
        else if (currentScene == "InfoScene" || currentScene == "Level1")
        {
            Screen.orientation = ScreenOrientation.LandscapeRight;
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        ApplyScreenOrientation();
    }
}