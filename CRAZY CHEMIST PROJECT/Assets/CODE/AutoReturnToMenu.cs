using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AutoReturnToMenu : MonoBehaviour
{
    public float returnTime = 40f; // 40 seconds countdown

    void Start()
    {
        StartCoroutine(ReturnToMenuAfterTime());
    }

    IEnumerator ReturnToMenuAfterTime()
    {
        yield return new WaitForSeconds(returnTime);
        SceneManager.LoadScene("StartMenuScene");
    }
}