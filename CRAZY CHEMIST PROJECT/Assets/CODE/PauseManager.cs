using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    public Image fadeImage;
    public float fadeDuration = 0.5f;

    private bool isPaused = false;

    public void PauseGame()
    {
        if (!isPaused)
        {
            StartCoroutine(FadeToBlack(true));
            pausePanel.SetActive(true);
            Time.timeScale = 0f; // Pauses everything
            isPaused = true;
        }
    }

    public void ResumeGame()
    {
        if (isPaused)
        {
            StartCoroutine(FadeToBlack(false));
            Time.timeScale = 1f;
            pausePanel.SetActive(false);
            isPaused = false;
        }
    }

    IEnumerator FadeToBlack(bool fadeOut)
    {
        float elapsedTime = 0f;
        Color startColor = fadeImage.color;
        Color targetColor = fadeOut ? new Color(0, 0, 0, 0.6f) : new Color(0, 0, 0, 0f);

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.unscaledDeltaTime;
            fadeImage.color = Color.Lerp(startColor, targetColor, elapsedTime / fadeDuration);
            yield return null;
        }
    }
}
